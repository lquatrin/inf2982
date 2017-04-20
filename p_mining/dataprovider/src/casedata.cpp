#pragma once

#include "casedata.h"

#include <cmath>

double CaseData::CompositeDistance (CaseData* a, CaseData* b)
{
  return exp(abs((double)a->creditscore - (double)b->creditscore));
}

CaseData::CaseData ()
{

}

CaseData::CaseData(std::string cn,
                   int scs,
                   float reqam,
                   int cdtscr,
                   int var,
                   int noof,
                   std::string lgoal)
{
  casename = cn;
  success = scs;
  requestamount = reqam;
  creditscore = cdtscr;
  variant = var;
  numberofoffers = noof;
  loangoal = lgoal;
}

CaseData::~CaseData ()
{

}