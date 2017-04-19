import csv

dct_casesinfo = dict()
fields = dict()

case_fields = [ "Success", "RequestAmount", "CreditScore", "Variant", "NumberOfOffers", "LoanGoal" ]

with open("data/app_log_cap.csv", "r") as f:
  reader = csv.reader(f, delimiter=";")
  for i, line in enumerate(reader):
    if i == 0:
      for v in range(len(line)):
        fields[v] = line[v]
        print(v, line[v])
    else:
      if dct_casesinfo.get(line[0]) == None:
        dct_casesinfo[line[0]] = dict()
        dct_casesinfo[line[0]]["Success"] = 0
        dct_casesinfo[line[0]]["CreditScore"] = 0
        dct_casesinfo[line[0]]["NumberOfOffers"] = 0
        dct_casesinfo[line[0]]["LoanGoal"] = ''
        

      # "Success"
      # Loan Success
      if line[1].lower() == 'A_Pending'.lower():
        dct_casesinfo[line[0]]["Success"] = 1

      # "RequestAmount"
      # Request Amount
      if not (line[12] == 'End' ):
        dct_casesinfo[line[0]]["RequestAmount"] = float(line[12])

      # "CreditScore"
      # CreditScore
      if not (line[15] == '' or line[15] == 'End' or line[15] == '0'):
        #if not (dct_casesinfo[line[0]].get("CreditScore") == None):
        #  print(int(line[15]), dct_casesinfo[line[0]][fields[15]])
        dct_casesinfo[line[0]]["CreditScore"] = int(line[15])

      # "Variant"
      # Variant index
      dct_casesinfo[line[0]]["Variant"] = int(line[6])

      # "NumberOfOffers"
      # Number Of Offers (Activity == O_Create Offer)
      if line[1].lower() == 'O_Create Offer'.lower():
        dct_casesinfo[line[0]]["NumberOfOffers"] = dct_casesinfo[line[0]]["NumberOfOffers"] + 1 

      # "LoanGoal"
      # Loan Goal
      if not (line[11] == 'End' ):
        dct_casesinfo[line[0]]["LoanGoal"] = line[11].replace(' ', '')


f = open('data/case_data.txt','w')
f.write("CaseName")
for val in case_fields:
  f.write('\t' + val)
f.write('\n')

for case_name, case_data in dct_casesinfo.items():
  f.write(case_name)
  for val in case_fields:
    f.write('\t' + str(dct_casesinfo[case_name][val]))
  f.write('\n')
f.close()
