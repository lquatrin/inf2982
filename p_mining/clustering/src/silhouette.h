#ifndef SILHOUETTE_H
#define SILHOUETTE_H

#include <vector>

class Clustering;
class DsDist;

// quality measure for kmedoids
std::vector<float> silhouette(DsDist* dist_mat, Clustering& clust_info);

#endif // SILHOUETTE_H
