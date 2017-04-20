#pragma once

#include "reader.h"

#include <fstream>
#include <string>
#include <iostream>

std::vector<CaseData*> ReadCaseData (std::string filename)
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
  }
  casedatalist.close();

  return casedata;
}