import socket

sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

server_address = ("localhost", 5000)
sock.connect(server_address)

try:
    message = "AHOJ! JA jsem klient :D"
    sock.sendall(message.encode())
finally:
    sock.close()
