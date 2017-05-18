// This is the main DLL file.

#include "stdafx.h"

#include "CppWrapper.h"

#include "../MDS/mds.h"
#include "../MDS/mds.cpp"

#include "../dataprovider/src/casedata.h"
#include "../dataprovider/src/casedata.cpp"

#include "../dataprovider/src/reader.h"
#include "../dataprovider/src/reader.cpp"

CppWrapper::CppMDSWrapper::CppMDSWrapper()
{
  pCF = new CaseDataCoeficients();

  casedata_v = new std::vector<CaseData*>();

  param_number_of_cases = 0;
  casedata_v->swap(ReadCaseData("../../data/case_data.txt", pCF));
}

array<double, 2>^ CppWrapper::CppMDSWrapper::DataProviderMDS ()
{
  printf("Number of Cases: %d\n", param_number_of_cases);
  assert(param_number_of_cases <= (int)casedata_v->size());
  
  int number_of_cases = param_number_of_cases;

  double **m = (double**)malloc(number_of_cases * sizeof(double*));
  for (int i = 0; i < number_of_cases; i++){
    m[i] = (double*)malloc(number_of_cases * sizeof(double));
    for (int j = 0; j < number_of_cases; j++){
      m[i][j] = CaseData::CompositeDistance(casedata_v->at(i), casedata_v->at(j), pCF);
    }
  }

  pMDS = new MDSClass(m, number_of_cases);
  std::vector<std::vector<double>> vec = pMDS->calcMDS();

  array<double, 2>^ dists = gcnew array<double, 2>(number_of_cases, 2);
  for (int i = 0; i < number_of_cases; i++){
    for (int j = 0; j < 2; j++){
      dists[i, j] = vec[i][j];
    }
  }

  return dists;
}

void CppWrapper::CppMDSWrapper::SetCreditScoreCoeficientValue (double coef)
{
  if (pCF)
    pCF->coef_creditscore = coef;
}

void CppWrapper::CppMDSWrapper::SetRequestAmountCoeficientValue(double coef)
{
  if (pCF)
    pCF->coef_requestamount = coef;
}

void CppWrapper::CppMDSWrapper::SetNumberOfOffersCoeficientValue (double coef)
{
  if (pCF)
    pCF->coef_numberofoffers = coef;
}

void CppWrapper::CppMDSWrapper::SetLoanGoalCoeficientValue (double coef)
{
  if (pCF)
    pCF->coef_loangoal = coef;
}

int CppWrapper::CppMDSWrapper::GetMaxCasesCount ()
{
  return (int)casedata_v->size();
}

void CppWrapper::CppMDSWrapper::SetNumberOfCases (int n_cases)
{
  assert(n_cases <= (int)casedata_v->size());

  param_number_of_cases = n_cases;

  UpdateMaxValues(param_number_of_cases, casedata_v, pCF);
}

int CppWrapper::CppMDSWrapper::GetNumberOfCases ()
{
  return param_number_of_cases;
}

// 0 - Success / A_Pending
// 1 - Denied
// 2 - Cancelled
int CppWrapper::CppMDSWrapper::GetCaseEndInfo (int id)
{
  return casedata_v->at(id)->endsituation;
}

System::String^ CppWrapper::CppMDSWrapper::GetCaseName (int id)
{
  std::string str = casedata_v->at(id)->casename;
  return  msclr::interop::marshal_as<System::String^>(str);
}

System::String^ CppWrapper::CppMDSWrapper::GetCaseDataInfo (int id)
{
  std::string str = casedata_v->at(id)->casename;
  str.append("\n");

  str.append("Goal: ");
  str.append(casedata_v->at(id)->loangoal);
  str.append("\n");

  str.append("CreditScore: ");
  str.append(std::to_string(casedata_v->at(id)->creditscore));
  str.append("\n");

  str.append("RequestAmount: ");
  str.append(std::to_string(casedata_v->at(id)->requestamount));
  str.append("\n");

  str.append("NumberOfOffers: ");
  str.append(std::to_string(casedata_v->at(id)->numberofoffers));
  str.append("\n");

  return msclr::interop::marshal_as<System::String^>(str);
}