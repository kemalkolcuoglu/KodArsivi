import sys
import sqlite3
from PyQt5 import QtWidgets


class Pencere(QtWidgets.QWidget):
    def __init__(self):
        super().__init__()
        self.baglanti()
        self.init_ui()

    def baglanti(self):
        self.con = sqlite3.connect("veritabani.db")
        self.cursor = self.con.cursor()
        self.cursor.execute("CREATE TABLE IF NOT EXISTS Üyeler (Kullanıcı_Adı TEXT,Şifre TEXT)")
        self.con.commit()


    def init_ui(self):
        self.yazi_kullanici = QtWidgets.QLabel("Kullanıcı Adı")
        self.kullanici = QtWidgets.QLineEdit()
        self.yazi_parola = QtWidgets.QLabel("Şifre")
        self.parola = QtWidgets.QLineEdit()
        self.parola.setEchoMode(QtWidgets.QLineEdit.Password)
        self.giris_buton = QtWidgets.QPushButton("Giriş Yap")
        self.kayit_buton = QtWidgets.QPushButton("Kayıt Ol")
        self.yazi_alani = QtWidgets.QLabel("Hoşgeldiniz!\nLütfen Giriş Yapınız!")

        duzen = QtWidgets.QGridLayout()
        duzen.addWidget(self.yazi_kullanici)
        duzen.addWidget(self.kullanici)
        duzen.addWidget(self.yazi_parola)
        duzen.addWidget(self.parola)
        duzen.addWidget(self.giris_buton)
        duzen.addWidget(self.kayit_buton)
        duzen.addWidget(self.yazi_alani)

        self.setLayout(duzen)
        self.giris_buton.clicked.connect(self.giris)
        self.kayit_buton.clicked.connect(self.giris)
        self.show()

    def giris(self):
        sender = self.sender()

        ad = self.kullanici.text()
        sif = self.parola.text()
        self.kullanici.clear()
        self.parola.clear()

        if sender.text() == "Giriş Yap":
            self.cursor.execute("SELECT * FROM Üyeler WHERE Kullanıcı_Adı = ? AND Şifre = ?", (ad, sif))
            data = self.cursor.fetchall()
            print(data)

            if len(data) == 0:
                self.yazi_alani.setText("Hatalı Giriş!\nLütfen Tekrar Deneyiniz!")
            else:
                self.yazi_alani.setText("Giriş Onaylandı!\nKullanıcı : "+ad)
        else:
            self.cursor.execute("INSERT INTO Üyeler VALUES (?,?)",(ad,sif))
            self.con.commit()
            self.yazi_alani.setText("Kayıt Onaylandı!\nLütfen Giriş Yapınız!")
        self.con.close()

if __name__ == "__main__":
    app = QtWidgets.QApplication(sys.argv)
    pencere = Pencere()
    sys.exit(app.exec_())