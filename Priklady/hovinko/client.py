import socket

sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
address = ("localhost", 7777)

sock.connect(address)

msg = "ahoj"
sock.sendall(msg.encode())

