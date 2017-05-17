#pragma once

#include "reader.h"

#include <fstream>
#include <string>
#include <iostream>

std::vector<CaseData*> ReadCaseData (std::string filename, CaseDataCoeficients* cf, int r_number_of_cases)
{
  std::vector<CaseData*> casedata;

  std::string linecases;
  std::ifstream casedatalist(filename);

  // header 
  getline(casedatalist, linecases);

  std::string name;
  int success;
  float requestamount;
  int creditscore;
  int variant;
  int numberofoffers;
  std::string loangoal;
  while (casedatalist >> name >> success >> requestamount >> creditscore >> variant >> numberofoffers >> loangoal)
  {
    cf->max_requestamount = std::fmax(cf->max_requestamount, (double)requestamount);
    cf->max_creditscore = std::fmax(cf->max_creditscore, (double)creditscore);
    cf->max_numberofoffers = std::fmax(cf->max_numberofoffers, (double)numberofoffers);

    CaseData* cd = new CaseData(
      name,
      success,
      requestamount,
      creditscore,
      variant,
      numberofoffers,
      loangoal
    );
    casedata.push_back(cd);

    r_number_of_cases--;
    if (r_number_of_cases == 0)
      break;
  }
  casedatalist.close();

  return casedata;
}