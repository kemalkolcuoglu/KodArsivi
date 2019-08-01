import sys
from PyQt5 import QtWidgets

class Pencere(QtWidgets.QWidget):
    def __init__(self):
        super().__init__()

        self.init_ui()

    def init_ui(self):
        self.yazi_alani =  QtWidgets.QLineEdit()
        self.buton = QtWidgets.QPushButton("Yazdır")

        duzen = QtWidgets.QVBoxLayout()
        duzen.addWidget(self.yazi_alani)
        duzen.addWidget(self.buton)

        self.setLayout(duzen)
        self.show()

        self.buton.clicked.connect(self.tiklama)

    def tiklama(self):
        print(self.yazi_alani.text())

if __name__ == "__main__":
    app = QtWidgets.QApplication(sys.argv)
    pencere = Pencere()
    sys.exit(app.exec_())