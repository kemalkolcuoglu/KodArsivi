#Hayvan,Köpek,Kuş,At

class Hayvan():
    def __init__(self,adi,cinsi,yasi):
        print("Hayvan Sınıfının init Fonksiyonu Çalışıyor!")
        self.adi = adi
        self.cinsi = cinsi
        self.yasi = yasi

    def __str__(self):
        return ("Adı -> {}\nCinsi -> {}\nYaşı -> {}\n".format(self.adi,self.cinsi,self.yasi))

class Kedi(Hayvan):
    def __init__(self,adi,cinsi,yasi,cinsiyet):
        super().__init__(adi,cinsi,yasi)
        print("Kedi Sınıfının init Fonksiyonu Çalışıyor!")
        self.cinsiyet = cinsiyet
    def __str__(self):
        return ("Adı -> {}\nCinsi -> {}\nYaşı -> {}\nCinsiyeti -> {}\n".format(self.adi,self.cinsi,self.yasi,self.cinsiyet))

def Main():
    kedi1 = Kedi("Ponçik","Tekir",1.5,"Dişi")
    kedi2 = Kedi("Poyraz","Kırma",0.8,"Erkek")
    print()
    print(kedi1)
    print(kedi2)

if __name__ == "__main__":
    Main()
