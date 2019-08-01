import sys
from PyQt5 import QtWidgets
import random

class Pencere(QtWidgets.QWidget):
    def __init__(self):
        super().__init__()

        self.init_ui()

    def init_ui(self):
        self.yazi = QtWidgets.QLabel("Merhaba Dunya")
        self.buton = QtWidgets.QPushButton("Tıkla!")

        duzen = QtWidgets.QVBoxLayout()

        duzen.addStretch()
        duzen.addWidget(self.buton)
        duzen.addWidget(self.yazi)
        duzen.addStretch()

        self.setLayout(duzen)
        self.show()

        self.buton.clicked.connect(self.tikla)

    def tikla(self):
        self.deger = random.randint(1,100)
        self.yazi.setText("Yeni değer -> "+str(self.deger))

if __name__ == "__main__":
    app = QtWidgets.QApplication(sys.argv)
    pencere = Pencere()
    sys.exit(app.exec_())