import re

stringData = "I love undertime slopper 12345 and ILOVEUNDERTIMESLOPPER 3333 ;"

regexString = "(SLOPPER.*\d)"

result = re.findall(regexString, stringData, flags=re.I)
print(result)

