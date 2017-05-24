// This is the main DLL file.

#include "stdafx.h"

#include "CppWrapper.h"


#include "../LAMP/lamp.h"
#include "../LAMP/lamp.cpp"
#include "../LAMP/lamp_f.cpp"

#include "../MDS/mds.h"
#include "../MDS/mds.cpp"

#include "../dataprovider/src/casedata.h"
#include "../dataprovider/src/casedata.cpp"

#include "../dataprovider/src/reader.h"
#include "../dataprovider/src/reader.cpp"




CppWrapper::CppLAMPWrapper::CppLAMPWrapper()
{
	pCC = new LAMPClass();
}

CppWrapper::CppLAMPWrapper::CppLAMPWrapper(int *pInt, int arraySize)
{
	pCC = new LAMPClass(pInt, arraySize);
}

array<double, 2>^ CppWrapper::CppLAMPWrapper::GetLAMP(array<double, 2>^ tvalues, array<double, 2>^ controlPoints, array<int>^controlsidx, int controlsize, int arraySize)
{
	dists = tvalues;
	double **m = (double**)malloc(arraySize * sizeof(double*));
	double **cpoints = (double**)malloc(controlsize * sizeof(double*));
	int *cindex = (int*)malloc(controlsize * sizeof(int));

	for (int i = 0; i < arraySize; i++) {
		m[i] = (double*)malloc(2 * sizeof(double));
		for (int j = 0; j < 2; j++) {
			m[i][j] = tvalues[i, j];
		}
	}

	for (int i = 0; i < controlsize; i++) {
		cpoints[i] = (double*)malloc(2 * sizeof(double));
		cindex[i] = controlsidx[i];
		for (int j = 0; j < 2; j++) {
			cpoints[i][j] = controlPoints[i, j];
		}
	}

	pCC = new LAMPClass();
	std::vector<std::vector<double>> vec = pCC->calcLAMP(m, cindex, cpoints, arraySize, controlsize);

	for (int i = 0; i < vec.size(); i++) {
		for (int j = 0; j < vec[i].size(); j++) {
			dists[i, j] = vec[i][j];
		}
	}

	return dists;
}



double CppWrapper::CppLAMPWrapper::GetSum()
{
	sum = pCC->SumArray();

	return sum;
}

void CppWrapper::CppLAMPWrapper::testLamp()
{
	pCC->lampTest();
}

CppWrapper::CppMDSWrapper::CppMDSWrapper()
{
  pCF = new CaseDataCoeficients();

  casedata_v = new std::vector<CaseData*>();
}

array<double, 2>^ CppWrapper::CppMDSWrapper::DataProviderMDS ()
{
  casedata_v->swap(ReadCaseData("../../data/case_data.txt", pCF, 250));
  
  double **m = (double**)malloc((int)casedata_v->size() * sizeof(double*));
  for (int i = 0; i < (int)casedata_v->size(); i++){
    m[i] = (double*)malloc((int)casedata_v->size() * sizeof(double));
    for (int j = 0; j < (int)casedata_v->size(); j++){
      m[i][j] = CaseData::CompositeDistance(casedata_v->at(i), casedata_v->at(j), pCF);
    }
  }

  pMDS = new MDSClass(m, (int)casedata_v->size());
  std::vector<std::vector<double>> vec = pMDS->calcMDS();

  array<double, 2>^ dists = gcnew array<double, 2>((int)casedata_v->size(), 2);
  for (int i = 0; i < (int)casedata_v->size(); i++){
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

int CppWrapper::CppMDSWrapper::GetNumberOfCases ()
{
  return (int)casedata_v->size();
}

// 0 - Success / A_Pending
// 1 - Denied
// 2 - Cancelled
int CppWrapper::CppMDSWrapper::GetCaseEndInfo (int id)
{
  return casedata_v->at(id)->endsituation;
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