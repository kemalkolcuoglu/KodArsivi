import sys
from PyQt5 import QtWidgets

class Pencere(QtWidgets.QWidget):
    def __init__(self):
        super().__init__()
        self.init_ui()

    def init_ui(self):
        self.yazi_deger1 = QtWidgets.QLabel("Birinci Değer")
        self.yazi_deger2 = QtWidgets.QLabel("İkinci Değer")
        self.deger1 = QtWidgets.QLineEdit()
        self.deger2 = QtWidgets.QLineEdit()
        self.buton_toplama = QtWidgets.QPushButton("Topla")
        self.buton_carpma = QtWidgets.QPushButton("Çarp")
        self.sonuc = QtWidgets.QLabel()

        duzen = QtWidgets.QGridLayout()
        duzen.addWidget(self.yazi_deger1)
        duzen.addWidget(self.deger1)
        duzen.addWidget(self.yazi_deger2)
        duzen.addWidget(self.deger2)
        duzen.addWidget(self.buton_toplama)
        duzen.addWidget(self.buton_carpma)
        duzen.addWidget(self.sonuc)

        self.setLayout(duzen)
        self.setWindowTitle("Toplama ve Çarpma İşlemi")
        self.show()

        self.buton_toplama.clicked.connect(self.islem)
        self.buton_carpma.clicked.connect(self.islem)

    def islem(self):
        sender = self.sender()

        if sender.text() == "Topla":
            deger = str(int(self.deger1.text()) + int(self.deger2.text()))
            self.sonuc.setText(sender.text()+"manın Sonucu : "+deger)
        else:
            deger = str(int(self.deger1.text()) * int(self.deger2.text()))
            self.sonuc.setText(sender.text()+"manın Sonucu : "+deger)

if __name__ == "__main__":
    app = QtWidgets.QApplication(sys.argv)
    pencere = Pencere()
    sys.exit(app.exec_())
