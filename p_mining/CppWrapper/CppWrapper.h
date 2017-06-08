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

  public ref class CppDataProjProviderWrapper
  {
  public:
    CppDataProjProviderWrapper();

    array<double, 2>^ DataProviderMDS ();
    array<double, 2>^ DataProviderMDSCP (array<int>^ case_index, int case_length);
	array<double, 2>^ DataProviderMDSEditDist ();
	array<double, 2>^ DataProviderMDSJaccard();

    void SetCreditScoreCoeficientValue (double coef);
    void SetRequestAmountCoeficientValue (double coef);
    void SetNumberOfOffersCoeficientValue (double coef);
    void SetLoanGoalCoeficientValue (double coef);
	void SetJaccardCoeficientValue(double coef);
	void SetEditCoeficientValue(double coef);

    int GetMaxCasesCount ();
    void SetNumberOfCases (int n_cases);
    int GetNumberOfCases ();
    // 0 - Success / A_Pending
    // 1 - Denied
    // 2 - Cancelled
    int GetCaseEndInfo (int id);
    
    void UpdateMaxValuesUsingAllDataPoints(bool up_using_all);

    System::String^ GetCaseName(int id);

    System::String^ GetCaseDataInfo (int id);

    void InitLAMP (int* pInt, int arraySize);
    
    // Evaluate new points for lamp
    array<double, 2>^ DataProviderCasesLAMP (int id_init
      , int id_end
      , int lamp_control_points
      , array<int>^ lamp_control_points_index
      , array<double, 2>^ lamp_control_point_positions
    );

    array<double, 2>^ GetLAMP (array<double, 2>^ tvalues
      , array<double, 2>^ controlPoints
      , array<int>^controlsidx
      , int controlsize
      , int arraySize
    );


    double GetSum ();
    double sum;

    void testLamp ();

    array<int>^ FirstNVariants (int n_variants);

  private:
    double** EvaluateDistanceMatrixBetweenCases (std::vector<int> case_index, int case_length);
    std::vector<CaseData*>* casedata_v;

	  MDSClass* pMDS;
    CaseData* pCD;
    CaseDataCoeficients* pCF;
	  array<double, 2>^ dists;
    int param_number_of_cases;
    bool update_using_all_data_points;

    LAMPClass* pCC;
    array<double, 2>^ lamp_dists;
	double **editdist;
	double **jaccard;
  };

}
