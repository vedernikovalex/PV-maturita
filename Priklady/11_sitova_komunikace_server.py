import socket
sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

server_address = ('localhost', 5000)
sock.bind(server_address)

sock.listen()
print('Server byl zapnut!', server_address)

while True:
    print('Cekani na pripojeni...')
    connection, client_address = sock.accept()

    try:
        print('Spojeni s ' + str(client_address) + " bylo navazano!")
        data = connection.recv(1024)
        print('DATA: ' + str(data))
        message = 'Vasi zpravu jsme dostali!'
        connection.sendall(message.encode())

    finally:
        print("SPOJENI SERVERU BYLO UZAVRENO")
        connection.close()