import pymysql

connection = pymysql.connect(
    host="localhost",
    user="root",
    password="vysvetlovac",
    database="PV_10"
)

cursor = connection.cursor()
cursor.execute("select * from testovaci;")
result = cursor.fetchall()

for row in result:
    print(row)

print("___")
insertQuery = "insert into testovaci(jmeno,prijmeni,vek) values (%s, %s, %s)"
# sqlInjection = "insert into testovaci(jmeno,prijmeni,vek) values ('Test', "+"'Testik', 29); drop table testovaci; -- c"+", 20)"
insertParams = ("Test", "Insert", 20)
cursor.execute(insertQuery, insertParams)
connection.commit()


# entity mapping
class Testovaci:
    def __init__(self, id, jmeno, prijmeni, vek):
        self.id = id
        self.jmeno = jmeno
        self.prijmeni = prijmeni
        if vek == None:
            self.vek = 0
        self.vek = vek

    def __str__(self):
        return str(self.id) + " " + self.jmeno + " " + self.prijmeni + " " + str(self.vek)

    def get_tuple(self):
        return (self.id, self.jmeno, self.prijmeni, self.vek)


cursor.execute("select * from testovaci;")
result = cursor.fetchall()

entities = []

count = 0
for row in result:
    idcko, jmeno, prijmeni, vek = result[count]
    testicekEntity = Testovaci(idcko, jmeno, prijmeni, vek)
    entities.append(testicekEntity)
    count = count + 1

for entity in entities:
    print(entity)

cursor.close()
connection.close()
