// This is the main DLL file.

#include "stdafx.h"

#include "CppWrapper.h"

#include "../dataprovider/src/casedata.h"
#include "../dataprovider/src/casedata.cpp"
#include "../dataprovider/src/reader.h"
#include "../dataprovider/src/reader.cpp"

CppWrapper::CppDataProviderWrapper::CppDataProviderWrapper()
{

}

void CppWrapper::CppDataProviderWrapper::TestDataProvider ()
{
  std::vector<CaseData*> casedata_v = ReadCaseData("../../data/case_data.txt");

  for (int i = 0; i < casedata_v.size(); i++)
  {
    std::cout << casedata_v[i]->casename << std::endl;

    delete casedata_v[i];
    casedata_v[i] = NULL;
  }

}