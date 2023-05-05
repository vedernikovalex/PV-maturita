#recursion
def recursion(x):
    if x == 0:
        return x
    print(x)
    recursion(x-1)


print(recursion(4))


import itertools

# nastavime heslo cile
password = "summ202"

# dame algoritmu znaky ze kterych muze cerpat
charset = "asdumyger012345"

# set the maximum length of the password to try
max_length = len(password)

# iterate over all possible combinations of characters
# up to the maximum length
for length in range(1, max_length + 1):
    for guess in itertools.product(charset, repeat=length):
        # check if the guess matches the password
        if ''.join(guess) == password:
            print("Password found:", ''.join(guess))
            break

