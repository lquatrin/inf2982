// CppWrapper.h

#pragma once

#include "../dataprovider/src/casedata.h"
#include "../dataprovider/src/casedata.cpp"
#include "../dataprovider/src/reader.h"
#include "../dataprovider/src/reader.cpp"

using namespace System;

namespace CppWrapper {

	public ref class CppDataProviderWrapper
	{
  public:
    CppDataProviderWrapper ();
	
    void TestDataProvider ();
  private:
    CaseData* pCD;
  };
}
