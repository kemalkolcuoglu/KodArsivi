#Sayının yazılışını döndürme

def donusum(sayi):
    deger = sayi//10

    if deger<2:
        print("On",end=" ")
    elif deger<3:
        print("Yirmi",end=" ")
    elif deger<4:
        print("Otuz",end=" ")
    elif deger<5:
        print("Kırk",end=" ")
    elif deger<6:
        print("Elli",end=" ")
    elif deger<7:
        print("Atmış",end=" ")
    elif deger<8:
        print("Yetmiş",end=" ")
    elif deger<9:
        print("Seksen",end=" ")
    elif deger<10:
        print("Doksan",end=" ")

    deger = int(sayi%10)

    if deger<2:
        print("Bir",end=" ")
    elif deger<3:
        print("İki",end=" ")
    elif deger<4:
        print("Üç",end=" ")
    elif deger<5:
        print("Dört",end=" ")
    elif deger<6:
        print("Beş",end=" ")
    elif deger<7:
        print("Altı",end=" ")
    elif deger<8:
        print("Yedi",end=" ")
    elif deger<9:
        print("Sekiz",end=" ")
    elif deger<10:
        print("Dokuz",end=" ")

x=int(input("Bir Sayı Giriniz -> "))
donusum(x)

"""

Hocanın Kodu

birler =  ["","Bir","İki","Üç","Dört","Beş","Altı","Yedi","Sekiz","Dokuz"]
onlar = ["","On","Yirmi","Otuz","Kırk","Elli","Altmış","Yetmiş","Seksen","Doksan"]

def okunus(sayı):
    birinci = sayı % 10
    ikinci = sayı // 10
    
    return onlar[ikinci] + " " + birler[birinci]

    
sayı =  int(input("Sayı:"))

print(okunus(sayı))

"""
