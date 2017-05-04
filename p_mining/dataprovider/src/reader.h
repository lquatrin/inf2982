#ifndef DATA_PROVIDER_READER_H
#define DATA_PROVIDER_READER_H

#include "casedata.h"

#include <vector>
#include <iostream>

std::vector<CaseData*> ReadCaseData (std::string filename, CaseDataCoeficients* cf);

#endif // SILHOUETTE_H
