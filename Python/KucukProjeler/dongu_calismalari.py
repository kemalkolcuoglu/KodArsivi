"""
"Mükemmel Sayılar"

toplam = 0

for j in range(2,10000):
    for i in range(1,j):
        if j%i==0:
            toplam+=i
    if toplam == j:
        print("{} sayısı mükemmel sayıdır!".format(j))
    toplam = 0
"""

"""
"Armstrong Sayılar"

sayi = int(input("Bir Sayı Giriniz -> "))
toplam = 0
deger = list()
sayi1 = sayi
sayac = 0
while sayi1>0 :
    deger.append(sayi1%10)
    sayi1//=10
    sayac+=1
for i in deger:
    toplam += i**sayac

if toplam == sayi:
    print("{} sayısı Armstrong Sayısıdır!".format(sayi))
else:
    print("{} sayısı Armstrong Sayısı değildir!".format(sayi))

"""

