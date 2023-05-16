import os

path = "./logger.txt"
print(os.getcwd())
print(os.listdir("."))



file = open(path, "a")
file.write("HOJ\n")
file.flush()
file.close()


file =  open(path, "r")
print(file)

print(file.read())
file.close()

import pickle

osoba = {
    "jmeno": "Pavel",
    "prijmeni": "Pavel"
}

serialized = pickle.dumps(osoba)
print(serialized)
deserialized = pickle.loads(serialized)
print(deserialized)