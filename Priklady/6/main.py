import math
import sys
import time

def my_function(n):
    result = []
    for i in range(n):
        result.append(i)


input_sizes_time = [10000, 100000, 1000000, 10000000, 100000000]

def measure_time_complexity():
    for n in input_sizes_time:
        start = time.time()
        my_function(n)
        end = time.time()
        print("for "+str(n))
        result = end - start
        print("this time: "+str(result))


def data_complexity_n(n):
    # create a list of size n
    data = [0] * n
    # return the size of the list
    return len(data)


def data_complexity_logn(n):
    # calculate the log base 2 of n
    log_n = math.log2(n)
    # return the calculated value
    return log_n


# Example usage:
input_sizes_data = [10, 100, 1000, 10000, 1000000]

def measure_data_complexity():
    for n in input_sizes_data:
        complexity_n = data_complexity_n(n)
        complexity_log = data_complexity_logn(n)
        print(f"The N data complexity of {n} is O({complexity_n}).")
        print(f"The LOG N data complexity of {n} is O({complexity_log}).")
        print("")


measure_time_complexity()
measure_data_complexity()

# complexity

data = [1,2,3,4,5,6,7,8,9,10]

print(data[4])

data2 = []

n = 4
for i in range(n):
    data2.append(i)

print(data2)

data3 = []
for i in range(n):
    data3.append([])
    for y in range(n):
        data3[i].append(y)

print(data3)

