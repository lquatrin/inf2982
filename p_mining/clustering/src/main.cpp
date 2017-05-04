#include <cstdio>
#include <cstdlib>
#include <cmath>

#include "dsdist.h"
#include "clustering.h"
#include "pam.h"
#include "silhouette.h"

float pairwise_eucl_dist(float* a, float* b, int num_dim)
{
  float d = 0.f;
  for (int i = 0; i < num_dim; ++i)
    d += pow((a[i] - b[i]), 2);
  return sqrt(d);
}

float pairwise_manh_dist(float* a, float* b, int num_dim)
{
  float d = 0.f;
  for (int i = 0; i < num_dim; ++i)
    d += abs(a[i] - b[i]);
  return d;
}

DsDist* eucl_dist(float** points, int num_points, int num_dim)
{
  DsDist* dist = new DsDist(num_points);

  for (int i = 0; i < num_points - 1; ++i)
    for (int j = i + 1; j < num_points; ++j)
      dist->Set(i, j, pairwise_eucl_dist(points[i], points[j], num_dim));

  return dist;
}

DsDist* manh_dist(float** points, int num_points, int num_dim)
{
  DsDist* dist = new DsDist(num_points);

  for (int i = 0; i < num_points - 1; ++i)
    for (int j = i + 1; j < num_points; ++j)
      dist->Set(i, j, pairwise_manh_dist(points[i], points[j], num_dim));

  return dist;
}

void dist_test(int N, int D)
{
  float** points = (float**) calloc(N, sizeof(float*));
  for (int i = 0; i < N; ++i) {
    points[i] = (float*) calloc(D, sizeof(float));
  }

  for (int i = 0; i < N; ++i) {
    printf("point %d = (", i);
    for (int j = 0; j < D; ++j) {
      points[i][j] = i + j;
      printf("%f", points[i][j]);
      if (j < D - 1)
	printf(" ,");
    }
    printf(")\n");
  }

  DsDist* eucl = eucl_dist(points, N, D);
  DsDist* manh = manh_dist(points, N, D);
  
  printf("\n-------------------------------------------\n");
  eucl->print(true);
  printf("\n-------------------------------------------\n");
  manh->print(true);
  
  for (int i = 0; i < N; ++i) {
    memset(points[i], 0, D * sizeof(float));
    free(points[i]);
    points[i] = nullptr;
  }

  memset(points, 0, N * sizeof(float));
  free(points);
  points = nullptr;
  
  delete eucl;
  delete manh;

  eucl = nullptr;
  manh = nullptr;
}

void clust_test(bool dist_eucl = false)
{
  const int N = 10;
  const int D = 2;
  
  float** points = (float**) calloc(N, sizeof(float*));
  for (int i = 0; i < N; ++i)
    points[i] = (float*) calloc(D, sizeof(float));

  points[0][0] = 2;  points[0][1] = 6;
  points[1][0] = 3;  points[1][1] = 4;
  points[2][0] = 3;  points[2][1] = 8;
  points[3][0] = 4;  points[3][1] = 7;
  points[4][0] = 6;  points[4][1] = 2;
  points[5][0] = 6;  points[5][1] = 4;
  points[6][0] = 7;  points[6][1] = 3;
  points[7][0] = 7;  points[7][1] = 4;
  points[8][0] = 8;  points[8][1] = 5;
  points[9][0] = 7;  points[9][1] = 6;

  // for (int i = 0; i < N; ++i) {
  //   printf("point %d = (", i);
  //   for (int j = 0; j < D; ++j) {
  //     printf("%f", points[i][j]);
  //     if (j < D - 1)
  // 	printf(" ,");
  //   }
  //   printf(")\n");
  // }

  DsDist* dist;
  if (dist_eucl == true)
    dist = eucl_dist(points, N, D);
  else
    dist = manh_dist(points, N, D);
  printf("--------------------------------------\n");
  dist->print(true);
  printf("\n\n");
  
  Clustering* clust = pam(dist, 2);
  std::vector<float> sil = silhouette(dist, *clust);

  printf("Clustering results:\n  Cost = %.3f\n  Number of clusters = %lu\n", clust->GetConfigCost(), clust->GetNumClusters());

  std::map<int, std::vector<int>> cluster_map = clust->BuildClusterMap();
  for (auto it : cluster_map) {
    printf("  %d - ", it.first);
    for (auto it2 : it.second)
      printf("%d ", it2);
    printf("\n");
  }
  printf("\n");

  printf("Silhouette results:\n");
  for (size_t i = 0; i < sil.size(); ++i)
    printf("  %lu - %f\n", i, sil[i]);
  
  // Cleanup.
  delete clust;
  clust = nullptr;

  delete dist;
  dist = nullptr;

  for (int i = 0; i < N; ++i) {
    memset(points[i], 0, D * sizeof(float));
    free(points[i]);
    points[i] = nullptr;
  }

  memset(points, 0, N * sizeof(float));
  free(points);
  points = nullptr;
}

int main()
{
  clust_test(false);
  printf("\n\n--------------------------------------\n\n");
  clust_test(true);
  
  getchar();

  return 0;
}
