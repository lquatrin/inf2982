// This is the main DLL file.

#include "stdafx.h"

#include "CppWrapper.h"

//#include "../MDS/mds.h"
//#include "../MDS/mds.cpp"

#include "../dataprovider/src/casedata.h"
#include "../dataprovider/src/casedata.cpp"

#include "../dataprovider/src/reader.h"
#include "../dataprovider/src/reader.cpp"


CppWrapper::CppDataProviderWrapper::CppDataProviderWrapper()
{
}

array<double, 2>^ CppWrapper::CppDataProviderWrapper::TestDataProvider ()
{
  std::vector<CaseData*> casedata_v = ReadCaseData(
    //"F:/GitHub/inf2982/data/case_data.txt"
    "D:/GitHub/inf2982/data/case_data.txt"
    );
  
  int number_of_cases = 20;

  double **m = (double**)malloc(number_of_cases * sizeof(double*));
  for (int i = 0; i < number_of_cases; i++){
    m[i] = (double*)malloc(number_of_cases * sizeof(double));
    for (int j = 0; j < number_of_cases; j++){
      m[i][j] = CaseData::CompositeDistance(casedata_v[i], casedata_v[j]);
    }
  }

  //pMDS = new MDSClass(m, number_of_cases);
  //std::vector<std::vector<double>> vec = pMDS->calcMDS();

  array<double, 2>^ dists = gcnew array<double, 2>(number_of_cases, 2);
  for (int i = 0; i < number_of_cases; i++){
    for (int j = 0; j < 2; j++){
      dists[i, j] = i + j;
      //vec[i][j];
  
    }
  }

  return dists;
}
