def listeye_at(deger):
    deger = deger[:-1]
    oyuncu = deger.split(",")
    return oyuncu

try:
    with open("futbolcular.txt","r") as dosya:
        futbolcu = list()
        for i in range(0,3):
            futbolcu.append(listeye_at(dosya.readline()))
        bjk = open("bjk.txt","a")
        gs = open("gs.txt","a")
        fb = open("fb.txt","a")
        for i in range(0,3):
            if futbolcu[i][1] == "Beşiktaş":
                bjk.write(futbolcu[i][0])
            elif futbolcu[i][1] == "Galatasaray":
                gs.write(futbolcu[i][0])
            else:
                fb.write(futbolcu[i][0])
        bjk.close()
        gs.close()
        fb.close()
except FileNotFoundError:
    print("Dosya Bulunamadı!")
