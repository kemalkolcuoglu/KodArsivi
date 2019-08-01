#EKOK Hesabı

asal = [2,3,5,7,11]

def EKOK(deger1,deger2):
    carpim = 1
    i = 0
    while(deger1>1 or deger2>1):
        if(deger1%asal[i]==0 or deger2%asal[i]==0):
            if(deger1%asal[i]==0):
                deger1=deger1//asal[i]
            if(deger2%asal[i]==0):
                deger2=deger2//asal[i]
            carpim*=asal[i]
        else:
            i+=1
    return carpim

#EBOB Hesabı

def EBOB(deger1,deger2):
    carpim = 1
    i = 0
    while(deger1>1 or deger2>1):
        if(deger1%asal[i]==0 or deger2%asal[i]==0):
            if(deger1%asal[i]==0 and deger2%asal[i]==0):
                carpim*=asal[i]
                deger1=deger1//asal[i]
                deger2=deger2//asal[i]
            else:
                if(deger1%asal[i]==0):
                    deger1=deger1//asal[i]
                if(deger2%asal[i]==0):
                    deger2=deger2//asal[i]
        else:
            i+=1
    return carpim

def Main():
    giris = input("EBOB ya da EKOK yazınız -> ")

    sayi1 = int(input("İlk Sayıyı Giriniz -> "))
    sayi2 = int(input("İkinci Sayıyı Giriniz -> "))

    if giris=="EBOB":
        print("EBOB ->",EBOB(sayi1,sayi2))
    elif giris=="EKOK":
        print("EKOK ->",EKOK(sayi1,sayi2))
    else:
        print("Doğru Değer Giriniz!")

Main()
