print("********************\nATM sistemine hoşgeldiniz\n********************")

print("""
İşlemler:

1. Bakiye Sorgulama
2. Para Yatırma
3. Para Çekme

Programdan 'q' tuşu ile çıkabilirsiniz.


""")

bakiye = 100

while True:
    giris = input("İşleminizi giriniz -> ")

    if giris == "1":
        print("\nGüncel Bakiyeniz -> {} TL \n".format(bakiye))
    elif giris == "2":
        giris = int(input("Yatırcağınız para miktarını giriniz -> "))
        bakiye += giris
        print("Para Yatırma İşleminiz Gerçekleşti!\n")
    elif giris == "3":
        giris = int(input("Çekeceğiniz para miktarını giriniz -> "))
        if giris > bakiye:
            print("Yetersiz bakiye!\n")
        else:
            bakiye -= giris
            print("Para Çekme İşleminiz Gerçekleşti!\n")
    elif giris == 'q':
        break
    else:
        print("Lütfen 1-3 arası bir işlem seçiniz!\n")
