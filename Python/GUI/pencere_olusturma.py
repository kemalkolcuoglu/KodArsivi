import sys
from PyQt5 import QtWidgets

def main():
    app = QtWidgets.QApplication(sys.argv)

    yazi1 = QtWidgets.QLabel("Merhaba GUI")
    buton = QtWidgets.QPushButton("Tıkla!")

    d_duzen = QtWidgets.QHBoxLayout()
    d_duzen.addWidget(yazi1)
    d_duzen.addWidget(buton)
    d_duzen.addStretch()
    y_duzen = QtWidgets.QVBoxLayout()
    y_duzen.addLayout(d_duzen)
    y_duzen.addStretch()

    pencere = QtWidgets.QWidget()
    pencere.resize(600,480)
    pencere.setLayout(y_duzen)

    pencere.setWindowTitle("PyQt 5")
    pencere.show()

    sys.exit(app.exec_())

if __name__ == "__main__":
    main()