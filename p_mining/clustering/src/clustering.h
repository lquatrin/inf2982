#ifndef CLUSTERING_H
#define CLUSTERING_H

#include <vector>
#include <map>

class Clustering
{
public:
  Clustering() {}
  
  ~Clustering()
  {
    m_cluster_labels.clear();
    m_centers.clear();
    m_config_cost = 0.f;
  }

  void SetConfigCost(float cost)
  {
    m_config_cost = cost;
  }
  
  float GetConfigCost()
  {
    return m_config_cost;
  }

  void SetLabels(std::vector<int>& labels)
  {
    m_cluster_labels = labels;
  }

  std::vector<int>& GetLabels()
  {
    return m_cluster_labels;
  }

  void SetCenters(std::vector<int>& centers)
  {
    m_centers = centers;
  }

  std::vector<int>& GetCenters()
  {
    return m_centers;
  }

  size_t GetNumClusters()
  {
    return GetCenters().size();
  }

  size_t GetNumPoints()
  {
    return GetLabels().size();
  }

  std::map<int, std::vector<int>> BuildClusterMap()
  {
    std::map<int, std::vector<int>> cluster_map;
    size_t num_points = GetNumPoints();
    size_t num_centers = GetNumClusters();

    for (size_t i = 0; i < num_centers; ++i)
      cluster_map[GetCenters()[i]] = std::vector<int>();
    
    for (size_t i = 0; i < num_points; ++i)
      cluster_map[GetLabels()[i]].push_back(i);
    
    return cluster_map;
  }
  
private:
  std::vector<int> m_cluster_labels;
  std::vector<int> m_centers;
  float m_config_cost;
};

#endif //  CLUSTERING_H
