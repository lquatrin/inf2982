#ifndef CASE_DATA_H
#define CASE_DATA_H

#include <string>
#include <vector>

class CaseDataCoeficients
{
public:
  CaseDataCoeficients();

  double coef_creditscore;
  double coef_requestamount;
  double coef_numberofoffers;
  double coef_loangoal;
  double coef_editdist;
  double coef_jaccard;

  double max_numberofoffers;
  double max_creditscore;


  double max_requestamount;

  int number_of_features;

private:

};

class CaseData
{
public:
  static double CompositeDistance (CaseData* a, CaseData* b, CaseDataCoeficients* cf,double jaccard,double edit);
  static int GetNumberOfFeatures (CaseDataCoeficients* cf);
  static std::vector<double> ConvertCaseToPoint (CaseData* p, CaseDataCoeficients* cf);

  CaseData ();
  CaseData (std::string casename,
            int endsit,
            float requestamount,
            int creditscore,
            int variant,
            int numberofoffers,
            std::string loangoal
  );

  ~CaseData ();

  std::string casename;
  int endsituation;
  float requestamount;
  int creditscore;
  int variant;
  int numberofoffers;
  std::string loangoal;

protected:

private:
  
};

static void UpdateMaxValues (int number_of_cases, std::vector<CaseData*>* case_datas, CaseDataCoeficients* cf);

#endif // PAM_H
