// ClassCppToCS_Wrapper.h

#pragma once

#include "../MDS/mds.h"
#include "../MDS/mds.cpp"

#include "../dataprovider/src/casedata.h"
#include "../dataprovider/src/casedata.cpp"

#include "../dataprovider/src/reader.h"
#include "../dataprovider/src/reader.cpp"

#include <msclr\marshal_cppstd.h>
#include <math.h>
using namespace System;

namespace CppWrapper {

  public ref class CppMDSWrapper
  {
    public:
	CppMDSWrapper(/*array<double,2>^ tvalues, int arraySize*/);
	array<double, 2>^ GetMDS();
    void testMDS();

    array<double, 2>^ TestDataProvider();

  private:

	MDSClass* pMDS;
  CaseData* pCD;
	array<double, 2>^ dists;
  };

}
