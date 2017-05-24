// ClassCppToCS_Wrapper.h

#pragma once

#include "../LAMP/lamp.h"
#include "../LAMP/lamp.cpp"
#include "../LAMP/lamp_f.cpp"

#include "../MDS/mds.h"
#include "../MDS/mds.cpp"

#include "../dataprovider/src/casedata.h"
#include "../dataprovider/src/casedata.cpp"

#include "../dataprovider/src/reader.h"
#include "../dataprovider/src/reader.cpp"

#include <msclr\marshal_cppstd.h>
#include <math.h>
using namespace System;

namespace CppWrapper {

  
	public ref class CppLAMPWrapper
	{
	public:
		CppLAMPWrapper();
		CppLAMPWrapper(int* pInt, int arraySize);
		array<double, 2>^ GetLAMP(array<double, 2>^ tvalues, array<double, 2>^ controlPoints, array<int>^controlsidx, int controlsize, int arraySize);

		double GetSum();
		double sum;

		void testLamp();

	private:
		LAMPClass* pCC;
		array<double, 2>^ dists;
	};


  public ref class CppMDSWrapper
  {
  public:
	  CppMDSWrapper ();

    array<double, 2>^ DataProviderMDS ();

    void SetCreditScoreCoeficientValue (double coef);
    void SetRequestAmountCoeficientValue (double coef);
    void SetNumberOfOffersCoeficientValue (double coef);
    void SetLoanGoalCoeficientValue (double coef);

    void SetNumberOfCases (int n_cases);
    int GetNumberOfCases ();
    int GetMaxCasesCount ();
    // 0 - Success / A_Pending
    // 1 - Denied
    // 2 - Cancelled
    int GetCaseEndInfo (int id);
    
    void UpdateMaxValuesUsingAllDataPoints(bool up_using_all);

    System::String^ GetCaseName(int id);

    System::String^ GetCaseDataInfo (int id);
  private:
    std::vector<CaseData*>* casedata_v;

	  MDSClass* pMDS;
    CaseData* pCD;
    CaseDataCoeficients* pCF;
	  array<double, 2>^ dists;
    int param_number_of_cases;
    bool update_using_all_data_points;
  };

}
