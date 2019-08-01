#Quiz1 Soru 1
"""
Klavyeden 0 ile 2 arasında bir sayı istenecektir:
0 girilirse ekrana MERHABA DUNYA
1 girilirse klavyeden bir isim istenecek ve ekrana MERHABA <girilen isim>
2 girilirse klavyeden bir isim, bir soyad istenecek ve ekrana
MERHABA <girilen isim> <girilen soyad > yazdırılacaktır.
"""
#-------
"""
sayi = int(input("Bir Sayı Giriniz (0-2) : "))
if sayi == 0:
  print("Merhaba Dünya!")
elif sayi == 1:
  ad = input("Adınızı Giriniz : ")
  print("Merhaba",ad)
elif sayi == 2:
  ad = input("Adınızı Giriniz : ")
  soyad = input("Soyadınızı Giriniz : ")
  print("Merhaba",ad,soyad)
else:
  print("Geçerli bir değer giriniz (0-2)")
"""

#------------------------------------------------------

#Quiz1 Soru 2
"""
Klavyeden a,b,c harfleri arasından bir karakter seçilmesi istenecektir:
• a girilirse ekrana MERHABA DUNYA yazdırılacaktır
• b girilirse klavyeden bir tamsayı istenecek ve bu tamsayının karesi ekrana yazdırılacaktır
• c girilirse klavyeden iki tamsayı istenecek ve ekrana bu 2 tamsayının aritmetik ortalaması yazdırılacaktır.
• a,b,c karakterleri dışında bir karakter girilmesi halinde ise Dogru karakter girmediniz mesjı ekrana yazdırılacaktır
"""
#-------
"""
harf = input("Bir harf giriniz (a-c) : ")
if harf == 'a':
  print("Merhaba Dunya!")
elif harf == 'b':
  sayi = int(input("Bir Sayı Giriniz : "))
  print(sayi**2)
elif harf == 'c':
  sayi1 = int(input("Birinci Sayıyı Giriniz : "))
  sayi2 = int(input("İkinci Sayıyı Giriniz : "))
  print("Aritmetik Ortalama :",(sayi1+sayi2)/2)
else:
  print("a-c arası değer giriniz!")  
"""

#--------------------------------------------------------

# Quiz2 Soru 1 EBOB-EKOK
"""
def EBOB(sayi1,sayi2):
  ebob = 1
  for i in range(1,sayi1):
    if(sayi2%i==0):
      if(sayi1%i==0):
        ebob = i
  print("\nEBOB : ",ebob)

def EKOK(sayi1,sayi2):
  ekok = 1
  for i in range(sayi1,1,-1):
    if(sayi2%i==0):
      if(sayi1%i==0):
        ekok = i
  print("\nEKOK : ",ekok)

while(True):
  secim = input("EBOB Hesabı için 'ebob', EKOK Hesabı için 'ekok' yazınız : ")
  if secim == "cikis":
    break
  sayi1 = int(input("Birinci Sayıyı Giriniz : "))
  sayi2 = int(input("İkinci Sayıyı Giriniz : "))
  
  if secim == "ebob":
    EBOB(sayi1,sayi2)
  elif secim == "ekok":
    EKOK(sayi1,sayi2)
  else:
    print("Geçerli bir değer giriniz! ('ebob' ya da 'ekok')")
  print()
"""
        
#---------------------------------------------------------

#Quiz2 Soru 2
"""
İki tane sayıyı kullanıcıdan isteyen ve bu iki sayının yarısını ekrana yazdıran programı yazdırınız
"""
#-------
"""
sayi1 = int(input("Birinci Sayıyı Giriniz : "))
sayi2 = int(input("İkinci Sayıyı Giriniz : "))

if sayi2<sayi1:
    sayi2,sayi1 = sayi1,sayi2

print("Küçük Sayının Yarısı :",(sayi1/2))

"""

#-------------------------------------------------------------

#Algoritma Programlama 2010 Vize Soru 2
"""
1den başlayarak klavyeden girilen bir sayıya kadar olan tüm çift
sayıların toplamını ekrana yazdıran programı yazınız.
"""
#-------
"""
sayi = int(input("Bir Sayı Giriniz : "))
toplam = 0
for i in range(sayi+1):
    if i%2==0:
        toplam+=i
print("Sayıların Toplamı : ",toplam)
"""

#-------------------------------------------------------------

#Algoritma Programlama 2010 Vize Soru 3
"""
Klavyeden sürekli olarak sayılar okunacaktır
(Kaç adet okunacağı önceden belli değildir).
Okunan sayının negatif ya da sıfır olması halinde program sonlandırılacaktır.
Bu sayıların toplamı ve sayıların arasından en büyük olanı ekrana
yazdırılacaktır. Örnek bir uygulama aşağıda gösterilmektedir:
1.Sayı : 13
2. Sayı: 17
3. Sayı : 0
Girilen sayılar arasından toplamı 30, en büyük olanı 17dir.
"""
#-------
"""
en_buyuk,toplam,sayi = 0,0,1

while sayi>0:
  sayi = int(input("Sayı Giriniz : "))
  if sayi<1:
      print("Sayıların Toplamı : ",toplam)
      print("En Büyük Sayı : ",en_buyuk)
      break
  toplam+=sayi
  if sayi>en_buyuk:
      en_buyuk = sayi
"""
#---------------------------------------------------------------

#Algoritma Programlama 2010 Vize Ek Konteyjan
"""
Klavyeden okunan N tane sayı içerisinde:
a. Pozitif sayıların ortalamasını
b. Tek sayıların toplamını
c. 100 ile 200 arasındaki sayıların toplamını bularak ekrana yazdıran programı yazınız.
NOT: N sayısı programın başında klavyeden alınacaktır. Ekrana yazdırılacak olan bilgiler (a,b,c
şıklarındaki) klavyeden veri okuma işlemi bittikten sonra bir defalığına yazdırılmalıdır.
"""
#-------
"""
N = int(input("Bir Sayı Giriniz : "))
print("Girdiğiniz sayı kadar sayı girmeniz gerekmektedir.")
p_toplam,p_sayi = 0,0
t_toplam = 0
y_toplam = 0
for i in range(N):
    i = int(input("Sayı Giriniz : "))
    if i>0:
        p_sayi+=1
        p_toplam+=i
    if i%2==1:
        t_toplam+=i
    if 100<i<200:
        print(i)
        y_toplam+=i
print("Pozitif Sayıların Ortalaması :",(p_toplam/p_sayi))
print("Tek Sayıların Toplamı :",t_toplam)
print("100 ile 200 Arasındaki Sayıların Toplamı :",y_toplam)
"""
