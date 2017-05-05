#ifndef DATA_PROVIDER_READER_H
#define DATA_PROVIDER_READER_H

#include "casedata.h"

#include <vector>
#include <iostream>

std::vector<CaseData*> ReadCaseData (std::string filename, CaseDataCoeficients* cf, int r_number_of_cases = -1);

#endif // SILHOUETTE_H
