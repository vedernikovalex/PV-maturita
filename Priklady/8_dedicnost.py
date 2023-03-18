class Zvire:
    def __init__(self,vyska,vaha,nazev):
        self.vyska = vyska
        self.vaha = vaha
        self.nazev = nazev

    def chodit(self):
        print("chdim")

    def jist(self):
        print("jim")


class Pes(Zvire):
    def __init__(self,vyska,vaha,nazev,rasa):
        #super - odkaz na rodicovskou tridu
        super().__init__(vyska,vaha,nazev)
        self.rasa = rasa

    def stekat(self):
        print("haf haf")

    def stekat(self, prizvuk):
        print("*"+str(prizvuk)+"* haf haf ")

    def stekat(self, prizvuk, pocet):
        for i in range(int(pocet)):
            print("*"+str(prizvuk)+"* haf haf ")

    def chodit(self):
        print("Chodim po čtyřech")


pes = Pes(100, 30, "Maxik", "Chihuahua")
pes.stekat()
pes.stekat("anglicky")
pes.stekat("francouzsky",3)
pes.chodit()