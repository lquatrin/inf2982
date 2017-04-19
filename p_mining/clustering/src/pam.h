#ifndef PAM_H
#define PAM_H

#include <vector>

class DsDist;
class Clustering;

Clustering* pam(DsDist* dist_mat, int num_centers, int max_iter = 30);

#endif // PAM_H
