#include <cstdio>
#include <cstdlib>
#include <cmath>

#include "reader.h"
#include "casedata.h"

#include <vector>

int main()
{
  std::vector<CaseData*> casedata_v = ReadCaseData("../../data/case_data.txt", NULL);

  for (int i = 0; i < casedata_v.size(); i++)
  {
    delete casedata_v[i];
    casedata_v[i] = NULL;
  }

  return 0;
}
