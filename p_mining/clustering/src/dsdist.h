#ifndef DSDIST_H
#define DSDIST_H

#include <cstdio>
#include <cstdlib>
#include <cstring>

class DsDist
{
 public:
  DsDist(int order = 1) :
    m_order(order)
  {
    int sn = order * (order - 1) / 2;
    m_data = (float*) calloc(sn, sizeof(float));
  }
  
  ~DsDist()
  {
    if (m_data != nullptr) {
      int sz = m_order * (m_order - 1) / 2;
      memset(m_data, 0, sizeof(float) * sz);
      free(m_data);
      m_data = nullptr;
    }
    m_order = 0;
  }

  float Get(int row, int col)
  {
    if (col == row)
      return 0.f;

    int r, c;
    if (col > row) {
      c = row;
      r = col;
    } else {
      c = col;
      r = row;
    }
    
    return GetElem(r, c);
  }

  void Set(int row, int col, float val)
  {
    if (col == row)
      return;

    int r, c;
    if(col > row) {
      c = row;
      r = col;
    } else {
      c = col;
      r = row;
    }

    SetElem(r, c, val);
  }

  void print(bool full_mat = false)
  {
    if (full_mat) {
      for (int i = 0; i < m_order; ++i) {
	for (int j = 0; j < m_order; ++j)
	  printf("%.3f\t", Get(i, j));
	printf("\n");
      }
    } else {
      //TODO (schardong): Finish this.
    }
  }

  int GetOrder()
  {
    return m_order;
  }
  
 private:
  int m_order;
  float* m_data;

  float GetElem(int row, int col)
  {
    int begin = row * (row - 1) / 2;
    int idx = begin + col;
    return m_data[idx];
  }

  void SetElem(int row, int col, float val)
  {
    int begin = row * (row - 1) / 2;
    int idx = begin + col;
    m_data[idx] = val;
  }
};

#endif // DSDIST_H
