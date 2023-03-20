import logging

logging.basicConfig(filename='log.txt', filemode='a', format='%(name)s - %(levelname)s - %(message)s')
logging.error('Nastala velika chyba')

while True:
    try:
        vek = int(input("zadejde vas vek: "))
        vek_za_dvacet = vek + 20
        print(vek_za_dvacet)
        break

    except ValueError:
        print("Neni cislo")

