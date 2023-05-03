#adresovani
cislo = 12
print(id(cislo))

cislo = cislo + 1
print(id(cislo))

cislo = cislo - 1
print(id(cislo))
print(hex(id(cislo)))

#garbage collecting
my_list = [1, 2, 3, 4, 5]
del my_list[2]
print(my_list)
del my_list
# print(my_list)

#reference
a = [1,2,3]
b = a
print(a)
print(b)
a.append(4)
print(b)
