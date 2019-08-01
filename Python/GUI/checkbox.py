import sys
from PyQt5.QtWidgets import QWidget,QApplication,QLabel,QCheckBox,QGridLayout,QStatusBar

class Pencere(QWidget):
    def __init__(self):
        super().__init__()
        self.c_box = QCheckBox("Merhaba Dunya")
        self.yazi = QLabel("Bir Python Kodu Daha!")
        self.bar = QStatusBar(self)
        self.init_ui()

    def init_ui(self):
        duzen = QGridLayout()
        duzen.addWidget(self.c_box)
        duzen.addWidget(self.yazi)
        duzen.addWidget(self.bar)

        self.setLayout(duzen)
        self.show()

        self.c_box.clicked.connect(self.tiklama)

    def tiklama(self):
        if self.c_box.isChecked()==True:
            self.yazi.setText("Güzel! CheckBox Çalışıyor!")
        else:
            self.yazi.setText("Tekrar Deneyek!")

if __name__ == "__main__":
    app = QApplication(sys.argv)
    pencere = Pencere()
    sys.exit(app.exec_())