import sys
import os
from PyQt5 import QtWidgets

class AnaPencere(QtWidgets.QMainWindow):
    def __init__(self):
        super().__init__()

        self.menu_olustur()
        self.pencere = Pencere()
        self.setWindowTitle("Metin Düzenleyici")
        self.setCentralWidget(self.pencere)
        self.show()

    def menu_olustur(self):
        self.menubar = self.menuBar()
        m_dosya = self.menubar.addMenu("Dosya")
        mi_yeni = QtWidgets.QAction("Yeni Dosya", self)
        mi_yeni.setShortcut("Ctrl+N")
        mi_ac = QtWidgets.QAction("Aç", self)
        mi_ac.setShortcut("Ctrl+O")
        mi_kaydet = QtWidgets.QAction("Kaydet", self)
        mi_kaydet.setShortcut("Ctrl+S")
        mi_cikis = QtWidgets.QAction("Çıkış", self)
        mi_cikis.setShortcut("Alt+F4")

        m_dosya.addAction(mi_yeni)
        m_dosya.addAction(mi_ac)
        m_dosya.addAction(mi_kaydet)
        m_dosya.addAction(mi_cikis)

        m_dosya.triggered.connect(self.tiklama)

    def tiklama(self, action):
        if action.text() == "Yeni Dosya":
            self.pencere.yeni_dosya()
        elif action.text() == "Aç":
            self.pencere.dosya_ac()
        elif action.text() == "Kaydet":
            self.pencere.dosya_kaydet()
        elif action.text() == "Çıkış":
            QtWidgets.qApp.quit()
            self.close()
            

class Pencere(QtWidgets.QWidget):
    def __init__(self):
        super(Pencere, self).__init__()

        self.yazialani = QtWidgets.QTextEdit()
        self.durum_yazisi = QtWidgets.QLabel("")
        self.init_ui()

    def init_ui(self):
        duzen = QtWidgets.QVBoxLayout()
        duzen.addWidget(self.yazialani)
        duzen.addWidget(self.durum_yazisi)

        self.setLayout(duzen)

    def yeni_dosya(self):
        self.yazialani.clear()
        self.durum_yazisi.setText("Yeni Dosya Açıldı")

    def dosya_ac(self):
        try:
            dosya_adi = QtWidgets.QFileDialog.getOpenFileName(self, "Dosya Aç", os.getenv("HOME"))

            with open(dosya_adi[0], "r", encoding = "utf-8") as dosya:
                self.yazialani.setText(dosya.read())

            self.durum_yazisi.setText("Dosya Açıldı -> " + dosya_adi[0])
        except FileNotFoundError:
            self.durum_yazisi.setText("Dosya Açılırken Hata Oluştu!\nLütfen Tekrar Deneyiniz!")

    def dosya_kaydet(self):
        try:
            dosya_adi = QtWidgets.QFileDialog.getSaveFileName(self, "Dosya Kaydet", os.getenv("HOME"))

            with open(dosya_adi[0], "w", encoding = "utf-8") as dosya:
                dosya.write(self.yazialani.toPlainText())

            self.durum_yazisi.setText("Dosya Kaydedildi -> " + dosya_adi[0])
        except:
            self.durum_yazisi.setText("Dosya Kaydedilirken Hata Oluştu!\nLütfen Tekrar Deneyiniz!")

if __name__ == "__main__" :
    app = QtWidgets.QApplication(sys.argv)
    anapencere = AnaPencere()
    sys.exit(app.exec_())
