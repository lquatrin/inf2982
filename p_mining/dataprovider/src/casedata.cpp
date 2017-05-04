#pragma once

#include "casedata.h"

#include <cmath>
#include <iostream>

#ifndef EPSILON_DISTANCE
#define EPSILON_DISTANCE 0.000001
#endif

CaseDataCoeficients::CaseDataCoeficients()
{
  coef_creditscore = 1.0;
  coef_requestamount = 1.0;
  coef_numberofoffers = 1.0;
  coef_loangoal = 1.0;
}

double CaseData::CompositeDistance(CaseData* a, CaseData* b, CaseDataCoeficients* cf)
{
  return
    cf->coef_creditscore * abs((double)a->creditscore - (double)b->creditscore)
    +
    cf->coef_requestamount * abs((double)a->requestamount - (double)b->requestamount)
    +
    cf->coef_numberofoffers * (double)abs(a->numberofoffers - b->numberofoffers)
    +
    cf->coef_loangoal * (double)(a->loangoal == b->loangoal)
    + 
    EPSILON_DISTANCE
    ;
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