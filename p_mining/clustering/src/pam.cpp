#include "pam.h"
#include "dsdist.h"
#include "clustering.h"

#include <ctime>
#include <vector>
#include <set>
#include <map>
#include <limits>

void bind_to_medoid(DsDist* dist_mat, std::set<int>& centers, std::vector<int>& cluster_members)
{
  int num_points = dist_mat->GetOrder();
  
  for (int i = 0; i < num_points; ++i)
    cluster_members[i] = -1;
  
  for (int i = 0; i < num_points; ++i) {
    if (centers.find(i) != centers.end())
      continue;

    float small_dist = std::numeric_limits<float>::infinity();
    for (auto it = centers.begin(); it != centers.end(); ++it) {
      if (dist_mat->Get(*it, i) < small_dist) {
	small_dist = dist_mat->Get(*it, i);
	cluster_members[i] = *it;
      }
    }
  }
}

double calc_cost(DsDist* dist_mat, std::set<int>& centers, std::vector<int>& cluster_members)
{
  int num_points = dist_mat->GetOrder();
  double cost = 0.f;

  for (int i = 0; i < num_points; ++i) {
    if (centers.find(i) != centers.end())
      continue;
    cost += dist_mat->Get(cluster_members[i], i);
  }

  return cost;
}

void print_config(DsDist* dist_mat, std::set<int>& centers, std::vector<int>& cluster_members)
{
  int num_points = dist_mat->GetOrder();
  printf("centroids = [");
  for (auto it = centers.begin(); it != centers.end(); ++it)
    printf("%d, ", *it);
  printf("]\n");

  printf("cluster members = [");
  for (int i = 0; i < num_points; ++i)
    printf("%d, ", cluster_members[i]);
  printf("]\n");

  printf("configuration cost = %lf\n\n", calc_cost(dist_mat, centers, cluster_members));
}

Clustering* pam(DsDist* dist_mat, int num_centers, int max_iter)
{
  if (dist_mat == nullptr || num_centers <= 0)
    return nullptr;
  if (num_centers >= dist_mat->GetOrder())
    return nullptr;

  int num_points = dist_mat->GetOrder();
  std::vector<int> clust_memb(num_points, -1);

  // Build phase
  srand(time(nullptr));
  std::set<int> center_set;
  do {
    center_set.insert(rand() % num_points);
  } while (center_set.size() < (size_t)num_centers);
  
  bind_to_medoid(dist_mat, center_set, clust_memb);

  // Swap phase
  bool changed = false;
  int curr_iter = 0;
  float curr_cost = calc_cost(dist_mat, center_set, clust_memb);
  
  do {
    std::set<int> new_centers = center_set;
    std::vector<int> new_clust_memb = clust_memb;
    
    int idx = 0;
    do {
      idx = rand() % num_points;
    } while (clust_memb[idx] == -1);

    new_centers.erase(clust_memb[idx]);
    new_centers.insert(idx);
    bind_to_medoid(dist_mat, new_centers, new_clust_memb);
    float new_cost = calc_cost(dist_mat, new_centers, new_clust_memb);
    
    if (new_cost < curr_cost) {
      center_set = new_centers;
      clust_memb = new_clust_memb;
      curr_cost = new_cost;
      changed = true;
      curr_iter = 0;
    } else {
      changed = false;
      curr_iter++;
    }
  } while (changed == true || curr_iter < max_iter);

  // Removing the "-1" marker from the clust_memb vector.
  for (int i = 0; i < num_points; ++i)
    clust_memb[i] = (clust_memb[i] == -1) ? i : clust_memb[i];

  std::vector<int> centers;
  for (auto it = center_set.begin(); it != center_set.end(); ++it)
    centers.push_back(*it);

  Clustering* cluster_info = new Clustering;
  cluster_info->SetConfigCost(curr_cost);
  cluster_info->SetLabels(clust_memb);
  cluster_info->SetCenters(centers);

  return cluster_info;
}
