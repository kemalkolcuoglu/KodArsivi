import math
import os
import random
import re
import sys

# Complete the extraLongFactorials function below.
def extraLongFactorials(n):
    result = 1
    for i in range(n, 1, -1):
        result *= i
        print('i -> {}, result -> {}'.format(i, result))
    return result

if __name__ == '__main__':
    n = int(input())

    a = extraLongFactorials(n)
    print(a)
