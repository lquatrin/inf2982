#include "silhouette.h"
#include "dsdist.h"
#include "clustering.h"

#include <map>
#include <vector>
#include<algorithm>

std::map<int, std::vector<int> > build_cluster_map(std::vector<int>& cluster_labels)
{
  std::map<int, std::vector<int> > cluster_map;

  for (size_t i = 0; i < cluster_labels.size(); ++i) {
    if (cluster_map.find(cluster_labels[i]) == cluster_map.end()) {
      std::vector<int> v;
      v.push_back(i);
      cluster_map[cluster_labels[i]] = v;
    } else {
      cluster_map[cluster_labels[i]].push_back(i);
    }
  }

  return cluster_map;
}

std::vector<float> silhouette(DsDist* dist_mat, Clustering& clust_info)
{
  int num_points = dist_mat->GetOrder();
  std::vector<float> intra_avg(num_points, 0.f);
  std::vector<float> inter_avg(num_points, 0.f);

  std::map<int, std::vector<int>> cluster_map = build_cluster_map(clust_info.GetLabels());

  for (auto it = cluster_map.begin(); it != cluster_map.end(); ++it) {
    //INTRA CLUSTER
    size_t clust_sz = it->second.size();
    for (size_t i = 0; i < clust_sz; ++i) {
      int curr_point = it->second[i];
      float curr_dist = 0.f;
      
      for (size_t j = 0; j < clust_sz; ++j) {
	if (i == j)
	  continue;

	int p = it->second[j];
	curr_dist += dist_mat->Get(p, curr_point);
      }
      curr_dist /= (clust_sz - 1);
      intra_avg[curr_point] = curr_dist;
    }

    //INTER CLUSTER
    std::map<int, std::vector<int>> tmp_map = cluster_map;
    tmp_map.erase(tmp_map.find(it->first));
    
    for (size_t i = 0; i < clust_sz; ++i) {
      std::vector<float> inter_dist(tmp_map.size(), 0.f);
      int idx = 0;
      int curr_point = it->second[i];
      
      for (auto jt = tmp_map.begin(); jt != tmp_map.end(); ++jt) {
	for (size_t j = 0; j < jt->second.size(); ++j) {
	  int p = jt->second[j];
	  inter_dist[idx] += dist_mat->Get(p, curr_point);
	}
	inter_dist[idx] /= (float)jt->second.size();
	++idx;
      }

      inter_avg[curr_point] = *std::min(inter_dist.begin(), inter_dist.end());
    }
  }

  std::vector<float> sil(num_points, 0.f);
  float avg_sil = 0.f;
  for (int i = 0; i < num_points; ++i) {
    float d = intra_avg[i] > inter_avg[i]? intra_avg[i] : inter_avg[i];
    sil[i] = (inter_avg[i] - intra_avg[i]) / d;
    avg_sil += sil[i];
  }
  
  avg_sil /= (float)num_points;

  return sil;
}
