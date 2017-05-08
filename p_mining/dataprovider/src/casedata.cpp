#pragma once

#include "casedata.h"

#include <cmath>
#include <iostream>

#ifndef EPSILON_DISTANCE
#define EPSILON_DISTANCE 0.0001
#endif

CaseDataCoeficients::CaseDataCoeficients()
{
  coef_creditscore = 1.0;
  coef_requestamount = 1.0;
  coef_numberofoffers = 1.0;
  coef_loangoal = 1.0;

  max_creditscore = 1300.0;
  max_requestamount = 55000.0;
}

double CaseData::CompositeDistance(CaseData* a, CaseData* b, CaseDataCoeficients* cf)
{
  return
    // Credit Score
    exp(cf->coef_creditscore * abs((double)(a->creditscore) / cf->max_creditscore - (double)(b->creditscore) / cf->max_creditscore))
    *
    // Request Amount
    exp(cf->coef_requestamount * abs((double)(a->requestamount) / cf->max_requestamount - (double)(b->requestamount) / cf->max_requestamount))
    *
    // Number Of Offers
    exp(cf->coef_numberofoffers * (double)abs(a->numberofoffers - b->numberofoffers))
    *
    // Loan Goal
    exp(cf->coef_loangoal * (double)(a->loangoal == b->loangoal))
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
  endsituation = scs;
  requestamount = reqam;
  creditscore = cdtscr;
  variant = var;
  numberofoffers = noof;
  loangoal = lgoal;
}

CaseData::~CaseData ()
{

}