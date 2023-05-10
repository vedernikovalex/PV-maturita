import os
print("")
currentPath = os.getcwd()
print(currentPath)
currentFiles = os.listdir(currentPath)
print(currentFiles)
pathOfLogFile = currentPath+"/../log.txt"
print(pathOfLogFile)
print(os.path.exists(pathOfLogFile))

soubor = open("../log.txt")
print(soubor.read())

import pickle
data = {'name': 'Alice', 'age': 25, 'hobbies': ['reading', 'traveling']}
serialized_data = pickle.dumps(data)
print(serialized_data)

deserialized_data = pickle.loads(serialized_data)
print(deserialized_data)

import json
data = {'name': 'Alice', 'age': 25, 'hobbies': ['reading', 'traveling']}
serialized_json = json.dumps(data)
print(serialized_json)
deserialized_json = json.loads(serialized_json)
print(deserialized_json)

