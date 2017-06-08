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
  coef_jaccard = 1.0;
  coef_editdist = 1.0;

  max_numberofoffers = -1.0;
  max_creditscore = -1.0;
  max_requestamount = -1.0;
}

double CaseData::CompositeDistance(CaseData* a, CaseData* b, CaseDataCoeficients* cf,double jaccard,double editdist)
{
  return 1.0 - (
    // Credit Score
    exp(-cf->coef_creditscore * std::fabs((double)(a->creditscore - b->creditscore)) / cf->max_creditscore) *
    // Request Amount
    exp(-cf->coef_requestamount * std::fabs((double)(a->requestamount - b->requestamount)) / cf->max_requestamount) *
    // Number Of Offers
    exp(-cf->coef_numberofoffers * std::fabs((double)(a->numberofoffers - b->numberofoffers)) / cf->max_numberofoffers) *
    // Loan Goal
    exp(-cf->coef_loangoal * (double)(a->loangoal != b->loangoal)) *
	  // jaccard
	  exp(-cf->coef_jaccard * jaccard) *
	  // editdist
	  exp(-cf->coef_editdist * editdist)
  )

  //std::sqrt(
  //  std::pow(a->variant - b->variant, 2) +
  //  std::pow(a->creditscore - b->creditscore, 2) +
  //  std::pow(a->requestamount - b->requestamount, 2) +
  //  std::pow(a->numberofoffers - b->numberofoffers, 2)
  //  
  //)
  ;
}

int CaseData::GetNumberOfFeatures (CaseDataCoeficients* cf)
{
  //variant
  //requestamount
  //creditscore
  //numberofoffers

  return 4;
}

std::vector<double> CaseData::ConvertCaseToPoint (CaseData* p, CaseDataCoeficients* cf)
{
  std::vector<double> v;

  //variant
  v.push_back((double)p->variant);

  //requestamount
  v.push_back((double)p->requestamount);

  //creditscore
  v.push_back((double)p->creditscore);

  //numberofoffers
  v.push_back((double)p->numberofoffers);

  return v;
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

void UpdateMaxValues (int number_of_cases, std::vector<CaseData*>* case_datas, CaseDataCoeficients* cf)
{
  cf->max_numberofoffers = -1.0;
  cf->max_creditscore = -1.0;
  cf->max_requestamount = -1.0;

  for (int i = 0; i < number_of_cases; i++)
  {
    cf->max_requestamount = std::fmax(cf->max_requestamount, case_datas->at(i)->requestamount);
    cf->max_creditscore = std::fmax(cf->max_creditscore, case_datas->at(i)->creditscore);
    cf->max_numberofoffers = std::fmax(cf->max_numberofoffers, case_datas->at(i)->numberofoffers);
  }
}
