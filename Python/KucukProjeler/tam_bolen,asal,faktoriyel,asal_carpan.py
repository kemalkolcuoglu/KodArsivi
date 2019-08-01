#Tam Bölen Toplamaları
"""
sayi = int(input("Bir Sayı Giriniz : "))

for i in range(1,sayi+1):
    toplam = 0
    for j in range(1,i+1):
      if i%j==0:
        toplam+=j
    print(str(i)+" için tam bölen toplamı : "+str(toplam))
"""
#-------------------------------------------------------------

#Asal Sayı Bulan Program
"""
sayi = int(input("Bir Sayı Giriniz : "))
asal_mi = False

for i in range(2,sayi+1):
    for j in range(2,i):
        if i%j==0:
            asal_mi = True
    if asal_mi == True:
        print(str(i)+" Sayısı Asal Değildir!")
    else:
        print(str(i)+" Sayısı Asaldır!")
    asal_mi = False
"""
#-------------------------------------------------------------

#Faktöriyel Bulma
"""
sayi = int(input("Bir Sayı Giriniz : "))

for i in range(1,sayi+1):
    carpim = 1
    for j in range(1,i+1):
        carpim*=j
    print(str(i)+" Sayısının Faktöriyeli : "+str(carpim))
"""
#-------------------------------------------------------------

#Asal Çarpanların Bulunması
"""
sayi = int(input("Bir Sayı Giriniz : "))
print("Asal Çarpanları : ")
while sayi>1 :
    i=2
    if sayi%i==0:
        print(str(i))
        sayi/=i
    else:
        i+=1
"""
