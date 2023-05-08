import socket
import sys

sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

server_address = ('localhost', 5000)
print('Snaha se pripojit k ', server_address)
sock.connect(server_address)

try:
    message = 'Ahoj, server!'
    print(sys.getsizeof(message))
    sock.sendall(message.encode())

    data = sock.recv(1024)
    print('DATA:' + str(data))
finally:
    sock.close()
