// This is the main DLL file.

#include "stdafx.h"

#include "CppWrapper.h"


#include "../LAMP/lamp.h"
#include "../LAMP/lamp.cpp"
#include "../LAMP/lamp_f.cpp"

#include "../MDS/mds.h"
#include "../MDS/mds.cpp"

#include "../dataprovider/src/casedata.h"
#include "../dataprovider/src/casedata.cpp"

#include "../dataprovider/src/reader.h"
#include "../dataprovider/src/reader.cpp"

CppWrapper::CppDataProjProviderWrapper::CppDataProjProviderWrapper()
{
  pCF = new CaseDataCoeficients();
  pMDS = NULL;

  casedata_v = new std::vector<CaseData*>();

  update_using_all_data_points = false;
  param_number_of_cases = 0;
  casedata_v->swap(ReadCaseData("../../data/case_data.txt", pCF));


  std::vector<std::vector<double>> data;
  std::ifstream file("../../data/editDist.csv");

  editdist = (double**)malloc(3097 * sizeof(double*));
  for (int row = 0; row < 3097; ++row)
  {
	  std::string line;
	  std::getline(file, line);
	  if (!file.good())
		  break;

	  std::stringstream iss(line);
	  editdist[row] = (double*)malloc(3097 * sizeof(double));
	  for (int col = 0; col < 3097; ++col)
	  {
		  std::string val;
		  std::getline(iss, val, ';');
		  if (!iss.good())
			  break;

		  std::stringstream convertor(val);
		  double k;
		  convertor >> k;
		  editdist[row][col] = abs(1 - k);
	  }
	  //data.push_back(a);
  }

  std::ifstream file2("../../data/all_SimilarityMatrix.csv");

  jaccard = (double**)malloc(3097 * sizeof(double*));
  for (int row = 0; row < 3097; ++row)
  {
	  std::string line;
	  std::getline(file2, line);
	  if (!file2.good())
		  break;

	  std::stringstream iss(line);
	  jaccard[row] = (double*)malloc(3097 * sizeof(double));
	  for (int col = 0; col < 3097; ++col)
	  {
		  std::string val;
		  std::getline(iss, val, ';');
		  if (!iss.good())
			  break;

		  std::stringstream convertor(val);
		  double k;
		  convertor >> k;
		  jaccard[row][col] = abs(1 - k);
	  }
	  //data.push_back(a);
  }

  pCC = new LAMPClass();
}

array<double, 2>^ CppWrapper::CppDataProjProviderWrapper::DataProviderMDS ()
{
  printf("Number of Cases: %d\n", param_number_of_cases);
  assert(param_number_of_cases <= (int)casedata_v->size());
  
  int number_of_cases = param_number_of_cases;

  double **m = (double**)malloc(number_of_cases * sizeof(double*));
  for (int i = 0; i < number_of_cases; i++)
  {
    m[i] = (double*)malloc(number_of_cases * sizeof(double));
    for (int j = 0; j < number_of_cases; j++)
    {
	  int vari = casedata_v->at(i)->variant - 1;
	  int varj = casedata_v->at(j)->variant - 1;
	  double edition = editdist[vari][varj];
	  double jac = jaccard[vari][varj];
	  m[i][j] = CaseData::CompositeDistance(casedata_v->at(i), casedata_v->at(j), pCF,jac,edition);
    }
  }

  if (pMDS)
    delete pMDS;
  pMDS = new MDSClass(m, number_of_cases);
  std::vector<std::vector<double>> vec = pMDS->calcMDS();

  array<double, 2>^ dists = gcnew array<double, 2>(number_of_cases, 2);
  for (int i = 0; i < number_of_cases; i++)
  {
    for (int j = 0; j < 2; j++)
    {
      dists[i, j] = vec[i][j];
    }
  }

  return dists;
}


array<double, 2>^ CppWrapper::CppDataProjProviderWrapper::DataProviderMDSCP(array<int>^ case_index, int case_length)
{
  double **m = (double**)malloc(case_length * sizeof(double*));
  for (int i = 0; i < case_length; i++)
  {
    m[i] = (double*)malloc(case_length * sizeof(double));
    for (int j = 0; j < case_length; j++)
    {
		int vari = casedata_v->at(i)->variant - 1;
		int varj = casedata_v->at(j)->variant - 1;
		double edition = editdist[vari][varj];
		double jac = jaccard[vari][varj];
		m[i][j] = CaseData::CompositeDistance(casedata_v->at(case_index[i]), casedata_v->at(case_index[j]), pCF,jac,edition);
    }
  }

  if (pMDS)
    delete pMDS;
  pMDS = new MDSClass(m, case_length);
  std::vector<std::vector<double>> vec = pMDS->calcMDS();

  array<double, 2>^ dists = gcnew array<double, 2>(case_length, 2);
  for (int i = 0; i < case_length; i++)
  {
    for (int j = 0; j < 2; j++)
    {
      dists[i, j] = vec[i][j];
    }
  }

  return dists;
}


//TO DO -> separa
array<double, 2>^ CppWrapper::CppDataProjProviderWrapper::DataProviderMDSEditDist()
{
	//casedata_v->swap(ReadCaseData("../../data/case_data.txt", pCF, 2000));



	printf("Number of Cases: %d\n", param_number_of_cases);
	assert(param_number_of_cases <= (int)casedata_v->size());

	int number_of_cases = param_number_of_cases;

	double **m = (double**)malloc(number_of_cases * sizeof(double*));
	for (int i = 0; i < number_of_cases; i++)
	{
		m[i] = (double*)malloc(number_of_cases * sizeof(double));
		for (int j = 0; j < number_of_cases; j++)
		{
			int vari = casedata_v->at(i)->variant -1;
			int varj = casedata_v->at(j)->variant -1;
			m[i][j] = editdist[vari][varj];

		}
	}

	if (pMDS)
		delete pMDS;
	pMDS = new MDSClass(m, number_of_cases);
	std::vector<std::vector<double>> vec = pMDS->calcMDS();

	array<double, 2>^ dists = gcnew array<double, 2>(number_of_cases, 2);
	for (int i = 0; i < number_of_cases; i++)
	{
		for (int j = 0; j < 2; j++)
		{
			dists[i, j] = vec[i][j];
		}
	}

	return dists;
	
	
}


array<double, 2>^ CppWrapper::CppDataProjProviderWrapper::DataProviderMDSJaccard()
{
	//casedata_v->swap(ReadCaseData("../../data/case_data.txt", pCF, 2000));

	printf("Number of Cases: %d\n", param_number_of_cases);
	assert(param_number_of_cases <= (int)casedata_v->size());

	int number_of_cases = param_number_of_cases;

	double **m = (double**)malloc(number_of_cases * sizeof(double*));
	for (int i = 0; i < number_of_cases; i++)
	{
		m[i] = (double*)malloc(number_of_cases * sizeof(double));
		for (int j = 0; j < number_of_cases; j++)
		{
			int vari = casedata_v->at(i)->variant - 1;
			int varj = casedata_v->at(j)->variant - 1;
			m[i][j] = jaccard[vari][varj];

		}
	}

	if (pMDS)
		delete pMDS;
	pMDS = new MDSClass(m, number_of_cases);
	std::vector<std::vector<double>> vec = pMDS->calcMDS();

	array<double, 2>^ dists = gcnew array<double, 2>(number_of_cases, 2);
	for (int i = 0; i < number_of_cases; i++)
	{
		for (int j = 0; j < 2; j++)
		{
			dists[i, j] = vec[i][j];
		}
	}

	return dists;


}



void CppWrapper::CppDataProjProviderWrapper::SetCreditScoreCoeficientValue (double coef)
{
  if (pCF)
    pCF->coef_creditscore = coef;
}

void CppWrapper::CppDataProjProviderWrapper::SetRequestAmountCoeficientValue(double coef)
{
  if (pCF)
    pCF->coef_requestamount = coef;
}

void CppWrapper::CppDataProjProviderWrapper::SetNumberOfOffersCoeficientValue (double coef)
{
  if (pCF)
    pCF->coef_numberofoffers = coef;
}

void CppWrapper::CppDataProjProviderWrapper::SetLoanGoalCoeficientValue (double coef)
{
  if (pCF)
    pCF->coef_loangoal = coef;
}

void CppWrapper::CppDataProjProviderWrapper::SetJaccardCoeficientValue(double coef)
{
	if (pCF)
		pCF->coef_jaccard = coef;
}

void CppWrapper::CppDataProjProviderWrapper::SetEditCoeficientValue(double coef)
{
	if (pCF)
		pCF->coef_editdist = coef;
}

int CppWrapper::CppDataProjProviderWrapper::GetMaxCasesCount()
{
  return (int)casedata_v->size();
}

void CppWrapper::CppDataProjProviderWrapper::SetNumberOfCases(int n_cases)
{
  assert(n_cases <= (int)casedata_v->size());

  param_number_of_cases = n_cases;

  if (!update_using_all_data_points)
    UpdateMaxValues(param_number_of_cases, casedata_v, pCF);
}

int CppWrapper::CppDataProjProviderWrapper::GetNumberOfCases ()
{
  return param_number_of_cases;
}

// 0 - Success / A_Pending
// 1 - Denied
// 2 - Cancelled
int CppWrapper::CppDataProjProviderWrapper::GetCaseEndInfo (int id)
{
  return casedata_v->at(id)->endsituation;
}

void CppWrapper::CppDataProjProviderWrapper::UpdateMaxValuesUsingAllDataPoints(bool up_using_all)
{
  update_using_all_data_points = up_using_all;

  if (update_using_all_data_points)
    UpdateMaxValues((int)casedata_v->size(), casedata_v, pCF);
  else
    UpdateMaxValues(param_number_of_cases, casedata_v, pCF);
}

System::String^ CppWrapper::CppDataProjProviderWrapper::GetCaseName(int id)
{
  std::string str = casedata_v->at(id)->casename;
  return  msclr::interop::marshal_as<System::String^>(str);
}

System::String^ CppWrapper::CppDataProjProviderWrapper::GetCaseDataInfo (int id)
{
  std::string str = casedata_v->at(id)->casename;
  str.append("\n");

  str.append("Variant: ");
  str.append(std::to_string(casedata_v->at(id)->variant));
  str.append("\n");

  str.append("Goal: ");
  str.append(casedata_v->at(id)->loangoal);
  str.append("\n");

  str.append("CreditScore: ");
  str.append(std::to_string(casedata_v->at(id)->creditscore));
  str.append("\n");

  str.append("RequestAmount: ");
  str.append(std::to_string(casedata_v->at(id)->requestamount));
  str.append("\n");

  str.append("NumberOfOffers: ");
  str.append(std::to_string(casedata_v->at(id)->numberofoffers));
  str.append("\n");

  return msclr::interop::marshal_as<System::String^>(str);
}

void CppWrapper::CppDataProjProviderWrapper::InitLAMP (int *pInt, int arraySize)
{
  if (pCC)
    delete pCC;

  pCC = new LAMPClass(pInt, arraySize);
}

array<double, 2>^ CppWrapper::CppDataProjProviderWrapper::DataProviderCasesLAMP (int id_init
  , int id_end
  , int lamp_control_points
  , array<int>^ lamp_control_points_index
  , array<double, 2>^ lamp_control_point_positions)
{
  int array_size = id_end - id_init;
  //std::cout << array_size << std::endl;
  if (array_size <= 0) return nullptr;
  
  array_size = array_size + lamp_control_points;

  // just put the control points first
  int *control_points_ids = (int*)malloc(lamp_control_points * sizeof(int));
  for (int i = 0; i < lamp_control_points; i++)
    control_points_ids[i] = i;


  double **control_points = (double**)malloc(lamp_control_points * sizeof(double*));
  for (int i = 0; i < lamp_control_points; i++) {
    control_points[i] = (double*)malloc(2 * sizeof(double));
    for (int j = 0; j < 2; j++) {
      control_points[i][j] = lamp_control_point_positions[i, j];
    }
  }

  double **m = (double**)malloc(array_size * sizeof(double*));
  for (int i = 0; i < array_size; i++) {
    m[i] = (double*)malloc(array_size * sizeof(double));

    // Get the correct case_id
    int index_f;
    if (i < lamp_control_points)
      index_f = lamp_control_points_index[i];
    else
      index_f = id_init + (i - lamp_control_points);

    for (int j = 0; j < array_size; j++) {
      
      // Get the correct case_id
      int index_e;
      if (j < lamp_control_points)
        index_e = lamp_control_points_index[j];
      else
        index_e = id_init + (j - lamp_control_points);
	  int vari = casedata_v->at(i)->variant - 1;
	  int varj = casedata_v->at(j)->variant - 1;
	  double edition = editdist[vari][varj];
	  double jac = jaccard[vari][varj];
      m[i][j] = CaseData::CompositeDistance(casedata_v->at(index_f), casedata_v->at(index_e), pCF,jac,edition);
    }
  }

  if (pCC) delete pCC;
  
  pCC = new LAMPClass();
  std::vector<std::vector<double>> vec = pCC->calcLAMP(m
    , control_points_ids
    , control_points
    , array_size
    , lamp_control_points);

  //std::cout << vec.size() << std::endl;
  //for (int i = 0; i < vec.size(); i++) {
  //  for (int j = 0; j < vec[i].size(); j++) {
  //    std::cout << vec[i][j] << " ";
  //  }
  //  std::cout << std::endl;
  //}

  array<double, 2>^ r_points = gcnew array<double, 2>(vec.size(), 2);
  for (int i = 0; i < vec.size(); i++) {
    for (int j = 0; j < vec[i].size(); j++) {
      r_points[i, j] = vec[i][j];
    }
  }

  return r_points;
}

array<double, 2>^ CppWrapper::CppDataProjProviderWrapper::GetLAMP(array<double, 2>^ tvalues, array<double, 2>^ controlPoints, array<int>^controlsidx, int controlsize, int arraySize)
{
  lamp_dists = tvalues;
  double **m = (double**)malloc(arraySize * sizeof(double*));
  double **cpoints = (double**)malloc(controlsize * sizeof(double*));
  int *cindex = (int*)malloc(controlsize * sizeof(int));

  for (int i = 0; i < arraySize; i++) {
    m[i] = (double*)malloc(2 * sizeof(double));
    for (int j = 0; j < 2; j++) {
      m[i][j] = tvalues[i, j];
    }
  }

  for (int i = 0; i < controlsize; i++) {
    cpoints[i] = (double*)malloc(2 * sizeof(double));
    cindex[i] = controlsidx[i];
    for (int j = 0; j < 2; j++) {
      cpoints[i][j] = controlPoints[i, j];
    }
  }

  pCC = new LAMPClass();
  std::vector<std::vector<double>> vec = pCC->calcLAMP(m, cindex, cpoints, arraySize, controlsize);

  for (int i = 0; i < vec.size(); i++) {
    for (int j = 0; j < vec[i].size(); j++) {
      lamp_dists[i, j] = vec[i][j];
    }
  }

  return lamp_dists;
}

double CppWrapper::CppDataProjProviderWrapper::GetSum()
{
  sum = pCC->SumArray();

  return sum;
}

void CppWrapper::CppDataProjProviderWrapper::testLamp()
{
  pCC->lampTest();
}

array<int>^ CppWrapper::CppDataProjProviderWrapper::FirstNVariants (int n_variants)
{
  array<int>^ datapoints = gcnew array<int>(n_variants);
  for (int v = 0; v < n_variants; v++)
  {
    datapoints[v] = -1;
  }

  for (int v = 0; v < n_variants; v++)
  {
    int variant = v+1;
    for (int p = 0; p < casedata_v->size(); p++)
    {
      if (casedata_v->at(p)->variant == variant)
      {
        datapoints[v] = p;
        break;
      }
    }
  }

  return datapoints;
}
