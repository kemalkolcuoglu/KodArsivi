import sys
from PyQt5 import QtWidgets

class Pencere(QtWidgets.QWidget):
    def __init__(self):
        super().__init__()

        self.radio1 = QtWidgets.QRadioButton("1")
        self.radio3 = QtWidgets.QRadioButton("3")
        self.radio5 = QtWidgets.QRadioButton("5")
        self.radio7 = QtWidgets.QRadioButton("7")
        self.radio10 = QtWidgets.QRadioButton("10")
        self.check1 = QtWidgets.QCheckBox("1")
        self.check3 = QtWidgets.QCheckBox("3")
        self.check5 = QtWidgets.QCheckBox("5")
        self.check7 = QtWidgets.QCheckBox("7")
        self.check10 = QtWidgets.QCheckBox("10")

        self.init_ui()

    def init_ui(self):

        duzen = QtWidgets.QGridLayout()
        duzen.addWidget(self.radio1)
        duzen.addWidget(self.radio3)
        duzen.addWidget(self.radio5)
        duzen.addWidget(self.radio7)
        duzen.addWidget(self.radio10)
        duzen.addWidget(self.check1)
        duzen.addWidget(self.check3)
        duzen.addWidget(self.check5)
        duzen.addWidget(self.check7)
        duzen.addWidget(self.check10)

        self.setLayout(duzen)
        self.show()

        self.radio1.clicked.connect(self.tiklama)
        self.radio3.clicked.connect(self.tiklama)
        self.radio5.clicked.connect(self.tiklama)
        self.radio7.clicked.connect(self.tiklama)
        self.radio10.clicked.connect(self.tiklama)

    def tiklama(self):
        sender = self.sender()
        if sender.text() == self.check1.text():
            self.check1.setChecked(not self.check1.isChecked())
        elif sender.text() == self.check3.text():
            self.check3.setChecked(not self.check3.isChecked())
        elif sender.text() == self.check5.text():
            self.check5.setChecked(not self.check5.isChecked())
        elif sender.text() == self.check7.text():
            self.check7.setChecked(not self.check7.isChecked())
        elif sender.text() == self.check10.text():
            self.check10.setChecked(not self.check10.isChecked())

if __name__ == "__main__":
    app = QtWidgets.QApplication(sys.argv)
    pencere = Pencere()
    sys.exit(app.exec_())