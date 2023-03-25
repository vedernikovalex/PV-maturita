import socket

# nadeklarovani socketu
sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

#IP + PORT nastaveni
server_address = ('localhost', 5000)

# nastavit socketu IP a PORT
sock.bind(server_address)

# poslech prichozich spojeni (omezen na pouze jednoho klienta)
# pro kazdeho klienta se vytvori novy socket
sock.listen(1)

print('Server byl zapnut!', server_address)

while True:
    # ceka na pripojeni
    print('Cekani na pripojeni...')
    connection, client_address = sock.accept()

    try:
        print('Spojeni s ' + str(client_address) + " bylo navazano!")

        # Ziskavani dat od klienta
        data = connection.recv(1024)
        print('DATA: ' + str(data))

        # Odeslani napr. odpovedi
        # (odeslani svych dat, neplest s ACK packetem = dela sam TCP)
        message = 'Vasi zpravu jsme dostali!'
        connection.sendall(message.encode())

    finally:
        # uzavreni spojeni
        print("SPOJENI SERVERU BYLO UZAVRENO")
        connection.close()