// CppWrapper.h

#pragma once

//#include "../MDS/mds.cpp"
//#include "../MDS/mds.h"

#include "../dataprovider/src/casedata.h"
#include "../dataprovider/src/casedata.cpp"

#include "../dataprovider/src/reader.h"
#include "../dataprovider/src/reader.cpp"

#include <msclr\marshal_cppstd.h>
#include <math.h>

using namespace System;

namespace CppWrapper {

	public ref class CppDataProviderWrapper
	{
  public:
    CppDataProviderWrapper ();
	
    array<double, 2>^ TestDataProvider ();
    
  private:
    CaseData* pCD;
  };
}
