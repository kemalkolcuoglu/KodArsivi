"""
Question -> https://www.hackerrank.com/challenges/strong-password/problem
"""

def minimumNumber(n, password):
    # Return the minimum number of characters to make the password strong
    special_characters = "!@#$%^&*()-+"
    value = 0
    isDigitExists = False
    isLowerExists = False
    isUpperExists = False
    isSpecialExists = False
    if n < 6:
        value += (6 - n)
    else:
        value = n
        for i in password:
            if ord(i) >= 97 and ord(i) <= 112: 
                isLowerExists = True
            elif ord(i) >= 65 and ord(i) <= 90:
                isUpperExists = True
            elif special_characters.find(i) != -1:
                isSpecialExists = True
            elif ord(i) >= 48 and ord(i) <= 57: 
                isDigitExists = True
            if len(password) == n and isDigitExists and isLowerExists and isSpecialExists and isUpperExists:
                return 0
        else:
            value = 4 - (int(isDigitExists) + int(isLowerExists) + int(isSpecialExists) + int(isUpperExists))
    return value

text = '#HackerRank'
a = minimumNumber(len(text), text)
print(a)
