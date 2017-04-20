#ifndef CASE_DATA_H
#define CASE_DATA_H

#include <string>

class CaseData
{
public:
  static double CompositeDistance (CaseData* a, CaseData* b);
  
  CaseData ();
  CaseData (std::string casename,
            int success,
            float requestamount,
            int creditscore,
            int variant,
            int numberofoffers,
            std::string loangoal
  );

  ~CaseData ();

  std::string casename;
  int success;
  float requestamount;
  int creditscore;
  int variant;
  int numberofoffers;
  std::string loangoal;

protected:

private:
  
};

#endif // PAM_H
