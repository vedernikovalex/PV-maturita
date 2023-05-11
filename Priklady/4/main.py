#lambdas
cislo = 12
pridej_sto = lambda x : x + 100 if isinstance(x, (int, float)) else None
print(pridej_sto(cislo))

#delegat
def pricti_cisla(x, y):
    return x + y

def odecti_cisla(x, y):
    return x - y

def vypocet(operace, x, y):
    return operace(x, y)

pricitat_delegat = pricti_cisla
odecitat_delegat = odecti_cisla

print(pricitat_delegat(1,2))

result = vypocet(pricitat_delegat, 5, 3)
print("Přičítání "+str(result))

result = vypocet(odecitat_delegat, 5, 3)
print("Odečítání "+str(result))



