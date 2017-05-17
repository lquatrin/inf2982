#ifndef CASE_DATA_H
#define CASE_DATA_H

#include <string>

class CaseDataCoeficients
{
public:
  CaseDataCoeficients();

  double coef_creditscore;
  double coef_requestamount;
  double coef_numberofoffers;
  double coef_loangoal;

  double max_numberofoffers;
  double max_creditscore;
  double max_requestamount;

private:

};

class CaseData
{
public:
  static double CompositeDistance (CaseData* a, CaseData* b, CaseDataCoeficients* cf);

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

#endif // PAM_H
