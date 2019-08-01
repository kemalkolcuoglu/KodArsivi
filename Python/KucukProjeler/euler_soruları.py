"""
# Project Euler 1. Soru
toplam = 0
for i in range(0,1000):
    if (i%3==0 or i%5==0):
        toplam +=i

print("Toplam ->",toplam)
"""
# ----------------------------
"""
# Project Euler 2. Soru
a,b = 1,1
toplam = 0
while (a<4000000):
    print(a,end=" ")
    a,b = b,a+b
    if a%2==0:
        toplam+=a
        
print("\nToplam ->",toplam)
"""
# ----------------------------
"""
#Project Euler 3. Soru
asal_carpanlar = list()
durum = bool()
i = 2
sayı = 600851475143
while(sayı>1):
    durum = False
    for j in range(2,i):
        if i%j==0:
            durum = True
            break
    if durum is False:
        while(True):
            if sayı%i==0:
                asal_carpanlar.append(i)
                sayı/=i
                #print("##Sayı->",sayı)
            else:
                break
    #print("Kalan Sayı ->",sayı)
    i+=1

print(asal_carpanlar)
"""
# ----------------------------
"""
# Project Euler 4. Soru
dizi = list()
for i in range(100,1000):
    for j in range(i,1000):
        sayi = k = i*j
        yazi = str()
        while sayi>0:
            yazi += str(sayi%10)
            sayi = sayi//10
        if k == int(yazi):
            dizi.append(k)
print(dizi)
"""
