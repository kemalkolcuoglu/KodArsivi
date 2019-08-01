class Bilgisayar():
    def __init__(self,marka="Tanımsız", model="Tanımsız", ozellikler={"CPU":"Tanımsız", "RAM":1, "HDD":16}):
        self.marka = marka
        self.model = model
        self.ozellikler = ozellikler
        print("Init Fonksiyonu Çalıştı!")

    def IS(self,os):
        self.os = os

    def __str__(self):
        return("""
        Bilgisayarın:
        Markası -> {}
        Modeli -> {}
        
        Özellikleri :
        CPU -> {}
        RAM -> {}
        HDD -> {}
        
        İşletim Sistemi -> {}
        """.format(self.marka, self.model, self.ozellikler["CPU"], self.ozellikler["RAM"], self.ozellikler["HDD"], self.os))

if __name__ == "__main__":
    pc = Bilgisayar("Dell", "Inspiron", {"CPU" : "I5", "RAM"  :4, "HDD" : 500})
    pc.IS("Pisi Linux")
    print(pc)