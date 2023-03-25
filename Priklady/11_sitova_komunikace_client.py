import socket

# tvorba TCP/IP socketu
sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)


# nadeklarovani IP a PORTU
server_address = ('localhost', 5000)
print('Snaha se pripojit k ', server_address)
# pripojeni socketu k serveru podle hodnot
sock.connect(server_address)

try:
    # Odeslani dat
    message = 'Ahoj, server!'
    sock.sendall(message.encode())

    # Ziskavani dat od klienta
    data = sock.recv(1024)
    print('DATA:' + str(data))

finally:
    # Zavreni socketu
    sock.close()
