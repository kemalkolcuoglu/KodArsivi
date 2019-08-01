from PyQt5 import QtCore, QtGui, QtWidgets
import time,random,sys
class Ui_Form(object):
    def __init__(self):
        self.board=[]
        self.isaret=None
        self.oyunBasladi=None
        self.bilgIsaret=None

    def setupUi(self, Form):
        Form.setObjectName("Form")
        Form.setWindowModality(QtCore.Qt.WindowModal)
        Form.resize(270, 517)
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Fixed, QtWidgets.QSizePolicy.Fixed)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(Form.sizePolicy().hasHeightForWidth())
        Form.setSizePolicy(sizePolicy)
        font = QtGui.QFont()
        font.setPointSize(14)
        font.setBold(True)
        font.setWeight(75)
        Form.setFont(font)
        self.line_4 = QtWidgets.QFrame(Form)
        self.line_4.setGeometry(QtCore.QRect(-90, 510, 434, 16))
        self.line_4.setFrameShape(QtWidgets.QFrame.HLine)
        self.line_4.setFrameShadow(QtWidgets.QFrame.Sunken)
        self.line_4.setObjectName("line_4")
        self.verticalLayoutWidget_2 = QtWidgets.QWidget(Form)
        self.verticalLayoutWidget_2.setGeometry(QtCore.QRect(0, 150, 271, 89))
        self.verticalLayoutWidget_2.setObjectName("verticalLayoutWidget_2")
        self.verticalLayout_3 = QtWidgets.QVBoxLayout(self.verticalLayoutWidget_2)
        self.verticalLayout_3.setContentsMargins(0, 0, 0, 0)
        self.verticalLayout_3.setObjectName("verticalLayout_3")
        self.line_2 = QtWidgets.QFrame(self.verticalLayoutWidget_2)
        self.line_2.setFrameShape(QtWidgets.QFrame.HLine)
        self.line_2.setFrameShadow(QtWidgets.QFrame.Sunken)
        self.line_2.setObjectName("line_2")
        self.verticalLayout_3.addWidget(self.line_2)
        self.btnOyunaBasla = QtWidgets.QPushButton(self.verticalLayoutWidget_2)
        self.btnOyunaBasla.setObjectName("btnOyunaBasla")
        self.verticalLayout_3.addWidget(self.btnOyunaBasla)
        self.line = QtWidgets.QFrame(self.verticalLayoutWidget_2)
        self.line.setFrameShape(QtWidgets.QFrame.HLine)
        self.line.setFrameShadow(QtWidgets.QFrame.Sunken)
        self.line.setObjectName("line")
        self.verticalLayout_3.addWidget(self.line)
        self.lblOyunAciklama = QtWidgets.QLabel(self.verticalLayoutWidget_2)
        font = QtGui.QFont()
        font.setPointSize(14)
        font.setBold(False)
        font.setWeight(50)
        self.lblOyunAciklama.setFont(font)
        self.lblOyunAciklama.setObjectName("lblOyunAciklama")
        self.verticalLayout_3.addWidget(self.lblOyunAciklama)
        self.horizontalLayoutWidget_2 = QtWidgets.QWidget(Form)
        self.horizontalLayoutWidget_2.setGeometry(QtCore.QRect(0, 80, 271, 71))
        self.horizontalLayoutWidget_2.setObjectName("horizontalLayoutWidget_2")
        self.horizontalLayout_2 = QtWidgets.QHBoxLayout(self.horizontalLayoutWidget_2)
        self.horizontalLayout_2.setSizeConstraint(QtWidgets.QLayout.SetDefaultConstraint)
        self.horizontalLayout_2.setContentsMargins(0, 0, 0, 0)
        self.horizontalLayout_2.setObjectName("horizontalLayout_2")
        self.label_2 = QtWidgets.QLabel(self.horizontalLayoutWidget_2)
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Maximum, QtWidgets.QSizePolicy.Fixed)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(self.label_2.sizePolicy().hasHeightForWidth())
        self.label_2.setSizePolicy(sizePolicy)
        font = QtGui.QFont()
        font.setPointSize(16)
        font.setBold(False)
        font.setWeight(50)
        self.label_2.setFont(font)
        self.label_2.setWordWrap(True)
        self.label_2.setObjectName("label_2")
        self.horizontalLayout_2.addWidget(self.label_2)
        self.line_6 = QtWidgets.QFrame(self.horizontalLayoutWidget_2)
        self.line_6.setFrameShape(QtWidgets.QFrame.VLine)
        self.line_6.setFrameShadow(QtWidgets.QFrame.Sunken)
        self.line_6.setObjectName("line_6")
        self.horizontalLayout_2.addWidget(self.line_6)
        self.btnIsaretO = QtWidgets.QPushButton(self.horizontalLayoutWidget_2)
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Fixed, QtWidgets.QSizePolicy.Maximum)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(self.btnIsaretO.sizePolicy().hasHeightForWidth())
        self.btnIsaretO.setSizePolicy(sizePolicy)
        self.btnIsaretO.setObjectName("btnIsaretO")
        self.horizontalLayout_2.addWidget(self.btnIsaretO)
        self.line_7 = QtWidgets.QFrame(self.horizontalLayoutWidget_2)
        self.line_7.setFrameShape(QtWidgets.QFrame.VLine)
        self.line_7.setFrameShadow(QtWidgets.QFrame.Sunken)
        self.line_7.setObjectName("line_7")
        self.horizontalLayout_2.addWidget(self.line_7)
        self.btnIsaretX = QtWidgets.QPushButton(self.horizontalLayoutWidget_2)
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Fixed, QtWidgets.QSizePolicy.Maximum)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(self.btnIsaretX.sizePolicy().hasHeightForWidth())
        self.btnIsaretX.setSizePolicy(sizePolicy)
        self.btnIsaretX.setObjectName("btnIsaretX")
        self.horizontalLayout_2.addWidget(self.btnIsaretX)
        self.verticalLayoutWidget = QtWidgets.QWidget(Form)
        self.verticalLayoutWidget.setGeometry(QtCore.QRect(0, 0, 271, 80))
        self.verticalLayoutWidget.setObjectName("verticalLayoutWidget")
        self.verticalLayout = QtWidgets.QVBoxLayout(self.verticalLayoutWidget)
        self.verticalLayout.setContentsMargins(0, 0, 0, 0)
        self.verticalLayout.setObjectName("verticalLayout")
        self.line_5 = QtWidgets.QFrame(self.verticalLayoutWidget)
        self.line_5.setFrameShape(QtWidgets.QFrame.HLine)
        self.line_5.setFrameShadow(QtWidgets.QFrame.Sunken)
        self.line_5.setObjectName("line_5")
        self.verticalLayout.addWidget(self.line_5)
        self.label = QtWidgets.QLabel(self.verticalLayoutWidget)
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Ignored, QtWidgets.QSizePolicy.Maximum)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(self.label.sizePolicy().hasHeightForWidth())
        self.label.setSizePolicy(sizePolicy)
        self.label.setAlignment(QtCore.Qt.AlignCenter)
        self.label.setObjectName("label")
        self.verticalLayout.addWidget(self.label)
        self.line_3 = QtWidgets.QFrame(self.verticalLayoutWidget)
        self.line_3.setFrameShape(QtWidgets.QFrame.HLine)
        self.line_3.setFrameShadow(QtWidgets.QFrame.Sunken)
        self.line_3.setObjectName("line_3")
        self.verticalLayout.addWidget(self.line_3)
        self.btn8 = QtWidgets.QPushButton(Form)
        self.btn8.setGeometry(QtCore.QRect(90, 240, 90, 90))
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Fixed, QtWidgets.QSizePolicy.Fixed)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(self.btn8.sizePolicy().hasHeightForWidth())
        self.btn8.setSizePolicy(sizePolicy)
        self.btn8.setBaseSize(QtCore.QSize(20, 20))
        font = QtGui.QFont()
        font.setPointSize(36)
        self.btn8.setFont(font)
        self.btn8.setLayoutDirection(QtCore.Qt.LeftToRight)
        self.btn8.setText("")
        self.btn8.setObjectName("btn8")
        self.btn9 = QtWidgets.QPushButton(Form)
        self.btn9.setGeometry(QtCore.QRect(180, 240, 90, 90))
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Fixed, QtWidgets.QSizePolicy.Fixed)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(self.btn9.sizePolicy().hasHeightForWidth())
        self.btn9.setSizePolicy(sizePolicy)
        self.btn9.setBaseSize(QtCore.QSize(20, 20))
        font = QtGui.QFont()
        font.setPointSize(36)
        self.btn9.setFont(font)
        self.btn9.setLayoutDirection(QtCore.Qt.LeftToRight)
        self.btn9.setText("")
        self.btn9.setObjectName("btn9")
        self.btn6 = QtWidgets.QPushButton(Form)
        self.btn6.setGeometry(QtCore.QRect(180, 330, 90, 90))
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Fixed, QtWidgets.QSizePolicy.Fixed)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(self.btn6.sizePolicy().hasHeightForWidth())
        self.btn6.setSizePolicy(sizePolicy)
        self.btn6.setBaseSize(QtCore.QSize(20, 20))
        font = QtGui.QFont()
        font.setPointSize(36)
        self.btn6.setFont(font)
        self.btn6.setLayoutDirection(QtCore.Qt.LeftToRight)
        self.btn6.setText("")
        self.btn6.setObjectName("btn6")
        self.btn4 = QtWidgets.QPushButton(Form)
        self.btn4.setGeometry(QtCore.QRect(0, 330, 90, 90))
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Fixed, QtWidgets.QSizePolicy.Fixed)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(self.btn4.sizePolicy().hasHeightForWidth())
        self.btn4.setSizePolicy(sizePolicy)
        self.btn4.setBaseSize(QtCore.QSize(20, 20))
        font = QtGui.QFont()
        font.setPointSize(36)
        self.btn4.setFont(font)
        self.btn4.setLayoutDirection(QtCore.Qt.LeftToRight)
        self.btn4.setText("")
        self.btn4.setObjectName("btn4")
        self.btn5 = QtWidgets.QPushButton(Form)
        self.btn5.setGeometry(QtCore.QRect(90, 330, 90, 90))
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Fixed, QtWidgets.QSizePolicy.Fixed)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(self.btn5.sizePolicy().hasHeightForWidth())
        self.btn5.setSizePolicy(sizePolicy)
        self.btn5.setBaseSize(QtCore.QSize(20, 20))
        font = QtGui.QFont()
        font.setPointSize(36)
        self.btn5.setFont(font)
        self.btn5.setLayoutDirection(QtCore.Qt.LeftToRight)
        self.btn5.setText("")
        self.btn5.setObjectName("btn5")
        self.btn2 = QtWidgets.QPushButton(Form)
        self.btn2.setGeometry(QtCore.QRect(90, 420, 90, 90))
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Fixed, QtWidgets.QSizePolicy.Fixed)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(self.btn2.sizePolicy().hasHeightForWidth())
        self.btn2.setSizePolicy(sizePolicy)
        self.btn2.setBaseSize(QtCore.QSize(20, 20))
        font = QtGui.QFont()
        font.setPointSize(36)
        self.btn2.setFont(font)
        self.btn2.setLayoutDirection(QtCore.Qt.LeftToRight)
        self.btn2.setText("")
        self.btn2.setObjectName("btn2")
        self.btn3 = QtWidgets.QPushButton(Form)
        self.btn3.setGeometry(QtCore.QRect(180, 420, 90, 90))
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Fixed, QtWidgets.QSizePolicy.Fixed)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(self.btn3.sizePolicy().hasHeightForWidth())
        self.btn3.setSizePolicy(sizePolicy)
        self.btn3.setBaseSize(QtCore.QSize(20, 20))
        font = QtGui.QFont()
        font.setPointSize(36)
        self.btn3.setFont(font)
        self.btn3.setLayoutDirection(QtCore.Qt.LeftToRight)
        self.btn3.setText("")
        self.btn3.setObjectName("btn3")
        self.btn1 = QtWidgets.QPushButton(Form)
        self.btn1.setGeometry(QtCore.QRect(0, 420, 90, 90))
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Fixed, QtWidgets.QSizePolicy.Fixed)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(self.btn1.sizePolicy().hasHeightForWidth())
        self.btn1.setSizePolicy(sizePolicy)
        self.btn1.setBaseSize(QtCore.QSize(20, 20))
        font = QtGui.QFont()
        font.setPointSize(36)
        self.btn1.setFont(font)
        self.btn1.setLayoutDirection(QtCore.Qt.LeftToRight)
        self.btn1.setText("")
        self.btn1.setObjectName("btn1")
        self.btn7 = QtWidgets.QPushButton(Form)
        self.btn7.setGeometry(QtCore.QRect(0, 240, 90, 90))
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Fixed, QtWidgets.QSizePolicy.Fixed)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(self.btn7.sizePolicy().hasHeightForWidth())
        self.btn7.setSizePolicy(sizePolicy)
        self.btn7.setBaseSize(QtCore.QSize(20, 20))
        font = QtGui.QFont()
        font.setPointSize(36)
        self.btn7.setFont(font)
        self.btn7.setLayoutDirection(QtCore.Qt.LeftToRight)
        self.btn7.setText("")
        self.btn7.setObjectName("btn7")

        self.retranslateUi(Form)
        QtCore.QMetaObject.connectSlotsByName(Form)
        self.btnIsaretX.clicked.connect(self.isaretXyap)
        self.btnIsaretO.clicked.connect(self.isaretOyap)
        self.btnOyunaBasla.clicked.connect(self.oyunaBasla)
        self.btn1.clicked.connect(self.hamle1)
        self.btn2.clicked.connect(self.hamle2)
        self.btn3.clicked.connect(self.hamle3)
        self.btn4.clicked.connect(self.hamle4)
        self.btn5.clicked.connect(self.hamle5)
        self.btn6.clicked.connect(self.hamle6)
        self.btn7.clicked.connect(self.hamle7)
        self.btn8.clicked.connect(self.hamle8)
        self.btn9.clicked.connect(self.hamle9)
    def kenaraOyna(self):
        kenarHamleler=[]
        if self.oyunBasladi:
            for i in range(2,10,2):
                if self.board[i]=="":
                    kenarHamleler.append(i)

            if len(kenarHamleler)==0:
                self.lblOyunAciklama.setText("Oyun Berabere!..")
                self.oyunBasladi = False
            else:
                secim = random.choice(kenarHamleler)
                if secim==2:
                    self.btn2.setText(self.bilgIsaret)
                elif secim==4:
                    self.btn4.setText(self.bilgIsaret)
                elif secim==6:
                    self.btn6.setText(self.bilgIsaret)
                elif secim==8:
                    self.btn8.setText(self.bilgIsaret)
    def ortayaOyna(self):
        if self.board[5]=="":
            self.btn5.setText(self.bilgIsaret)
        else:
            self.kenaraOyna()
    def koseyeOyna(self):
        koseHamleler=[]
        if self.oyunBasladi:
            if self.board[1]=="":
                koseHamleler.append(1)
            if self.board[3]=="":
                koseHamleler.append(3)
            if self.board[7]=="":
                koseHamleler.append(7)
            if self.board[9]=="":
                koseHamleler.append(9)
            if len(koseHamleler)==0:
                self.koseyeOyna()
            else:
                secim=random.choice(koseHamleler)
                if secim == 1:
                    self.btn1.setText(self.bilgIsaret)

                elif secim == 3:
                    self.btn3.setText(self.bilgIsaret)

                elif secim == 7:
                    self.btn7.setText(self.bilgIsaret)

                elif secim == 9:
                    self.btn9.setText(self.bilgIsaret)
    def kazanmaEngelle(self):
        engelleyenHamleler=[]
        if self.oyunBasladi:
            if self.board[1]=="" and self.board[2]==self.isaret and self.board[3]==self.isaret:
                engelleyenHamleler.append(123)

            if self.board[1]=="" and self.board[4]==self.isaret and self.board[7]==self.isaret:
                engelleyenHamleler.append(147)

            if self.board[1]=="" and self.board[5]==self.isaret and self.board[9]==self.isaret:
                engelleyenHamleler.append(159)

            if self.board[2]=="" and self.board[1]==self.isaret and self.board[3]==self.isaret:
                engelleyenHamleler.append(213)

            if self.board[2]=="" and self.board[5]==self.isaret and self.board[8]==self.isaret:
                engelleyenHamleler.append(258)

            if self.board[3]=="" and self.board[1]==self.isaret and self.board[2]==self.isaret:
                engelleyenHamleler.append(312)

            if self.board[3]=="" and self.board[5]==self.isaret and self.board[7]==self.isaret:
                engelleyenHamleler.append(357)

            if self.board[3]=="" and self.board[6]==self.isaret and self.board[9]==self.isaret:
                engelleyenHamleler.append(369)

            if self.board[4]=="" and self.board[1]==self.isaret and self.board[7]==self.isaret:
                engelleyenHamleler.append(417)

            if self.board[4]=="" and self.board[5]==self.isaret and self.board[6]==self.isaret:
                engelleyenHamleler.append(456)

            if self.board[5]=="" and self.board[1]==self.isaret and self.board[9]==self.isaret:
                engelleyenHamleler.append(519)

            if self.board[5]=="" and self.board[2]==self.isaret and self.board[8]==self.isaret:
                engelleyenHamleler.append(528)

            if self.board[5]=="" and self.board[3]==self.isaret and self.board[7]==self.isaret:
                engelleyenHamleler.append(537)

            if self.board[5]=="" and self.board[4]==self.isaret and self.board[6]==self.isaret:
                engelleyenHamleler.append(546)

            if self.board[6]=="" and self.board[3]==self.isaret and self.board[9]==self.isaret:
                engelleyenHamleler.append(639)

            if self.board[6]=="" and self.board[4]==self.isaret and self.board[5]==self.isaret:
                engelleyenHamleler.append(645)

            if self.board[7]=="" and self.board[1]==self.isaret and self.board[4]==self.isaret:
                engelleyenHamleler.append(714)

            if self.board[7]=="" and self.board[3]==self.isaret and self.board[5]==self.isaret:
                engelleyenHamleler.append(735)

            if self.board[7]=="" and self.board[8]==self.isaret and self.board[9]==self.isaret:
                engelleyenHamleler.append(789)

            if self.board[8]=="" and self.board[2]==self.isaret and self.board[5]==self.isaret:
                engelleyenHamleler.append(825)

            if self.board[8]=="" and self.board[7]==self.isaret and self.board[9]==self.isaret:
                engelleyenHamleler.append(879)

            if self.board[9]=="" and self.board[1]==self.isaret and self.board[5]==self.isaret:
                engelleyenHamleler.append(915)

            if self.board[9]=="" and self.board[3]==self.isaret and self.board[6]==self.isaret:
                engelleyenHamleler.append(936)

            if self.board[9]=="" and self.board[7]==self.isaret and self.board[8]==self.isaret:
                engelleyenHamleler.append(978)
            if len(engelleyenHamleler)==0:
                self.ortayaOyna()
            else:
                secim=random.choice(engelleyenHamleler)
                if secim == 123 and self.board[2] == self.isaret and self.board[3] == self.isaret:
                    self.btn1.setText(self.bilgIsaret)

                elif secim == 147 and self.board[4] == self.isaret and self.board[7] == self.isaret:
                    self.btn1.setText(self.bilgIsaret)

                elif secim == 159 and self.board[5] == self.isaret and self.board[9] == self.isaret:
                    self.btn1.setText(self.bilgIsaret)

                elif secim == 213 and self.board[1] == self.isaret and self.board[3] == self.isaret:
                    self.btn2.setText(self.bilgIsaret)

                elif secim == 258 and self.board[5] == self.isaret and self.board[8] == self.isaret:
                    self.btn2.setText(self.bilgIsaret)

                elif secim== 312 and self.board[1] == self.isaret and self.board[2] == self.isaret:
                    self.btn3.setText(self.bilgIsaret)

                elif secim == 357 and self.board[5] == self.isaret and self.board[7] == self.isaret:
                    self.btn3.setText(self.bilgIsaret)

                elif secim == 369 and self.board[6] == self.isaret and self.board[9] == self.isaret:
                    self.btn3.setText(self.bilgIsaret)

                elif secim == 417 and self.board[1] == self.isaret and self.board[7] == self.isaret:
                    self.btn4.setText(self.bilgIsaret)

                elif secim == 456 and self.board[5] == self.isaret and self.board[6] == self.isaret:
                    self.btn4.setText(self.bilgIsaret)

                elif secim == 519 and self.board[1] == self.isaret and self.board[9] == self.isaret:
                    self.btn5.setText(self.bilgIsaret)

                elif secim == 528 and self.board[2] == self.isaret and self.board[8] == self.isaret:
                    self.btn5.setText(self.bilgIsaret)

                elif secim == 537 and self.board[3] == self.isaret and self.board[7] == self.isaret:
                    self.btn5.setText(self.bilgIsaret)

                elif secim == 546 and self.board[4] == self.isaret and self.board[6] == self.isaret:
                    self.btn5.setText(self.bilgIsaret)

                elif secim == 639 and self.board[3] == self.isaret and self.board[9] == self.isaret:
                    self.btn6.setText(self.bilgIsaret)

                elif secim == 645 and self.board[4] == self.isaret and self.board[5] == self.isaret:
                    self.btn6.setText(self.bilgIsaret)

                elif secim == 714 and self.board[1] == self.isaret and self.board[4] == self.isaret:
                    self.btn7.setText(self.bilgIsaret)

                elif secim == 735 and self.board[3] == self.isaret and self.board[5] == self.isaret:
                    self.btn7.setText(self.bilgIsaret)

                elif secim == 789 and self.board[8] == self.isaret and self.board[9] == self.isaret:
                    self.btn7.setText(self.bilgIsaret)

                elif secim == 825 and self.board[2] == self.isaret and self.board[5] == self.isaret:
                    self.btn8.setText(self.bilgIsaret)

                elif secim == 879 and self.board[7] == self.isaret and self.board[9] == self.isaret:
                    self.btn8.setText(self.bilgIsaret)

                elif secim == 915 and self.board[1] == self.isaret and self.board[5] == self.isaret:
                    self.btn9.setText(self.bilgIsaret)

                elif secim == 936 and self.board[3] == self.isaret and self.board[6] == self.isaret:
                    self.btn9.setText(self.bilgIsaret)

                elif secim == 978 and self.board[7] == self.isaret and self.board[8] == self.isaret:
                    self.btn9.setText(self.bilgIsaret)
    def kazananHamleYap(self):
        if self.oyunBasladi:
            if self.board[1]=="" and self.board[2]==self.bilgIsaret and self.board[3]==self.bilgIsaret:
                self.btn1.setText(self.bilgIsaret)
                self.lblOyunAciklama.setText("Kaybettin!..")
                self.oyunBasladi=False
            elif self.board[1]=="" and self.board[4]==self.bilgIsaret and self.board[7]==self.bilgIsaret:
                self.btn1.setText(self.bilgIsaret)
                self.lblOyunAciklama.setText("Kaybettin!..")
                self.oyunBasladi = False
            elif self.board[1]=="" and self.board[5]==self.bilgIsaret and self.board[9]==self.bilgIsaret:
                self.btn1.setText(self.bilgIsaret)
                self.lblOyunAciklama.setText("Kaybettin!..")
                self.oyunBasladi = False
            elif self.board[2]=="" and self.board[1]==self.bilgIsaret and self.board[3]==self.bilgIsaret:
                self.btn2.setText(self.bilgIsaret)
                self.lblOyunAciklama.setText("Kaybettin!..")
                self.oyunBasladi=False
            elif self.board[2]=="" and self.board[5]==self.bilgIsaret and self.board[8]==self.bilgIsaret:
                self.btn2.setText(self.bilgIsaret)
                self.lblOyunAciklama.setText("Kaybettin!..")
                self.oyunBasladi = False
            elif self.board[3]=="" and self.board[5]==self.bilgIsaret and self.board[7]==self.bilgIsaret:
                self.btn3.setText(self.bilgIsaret)
                self.lblOyunAciklama.setText("Kaybettin!..")
                self.oyunBasladi = False
            elif self.board[3]=="" and self.board[1]==self.bilgIsaret and self.board[2]==self.bilgIsaret:
                self.btn3.setText(self.bilgIsaret)
                self.lblOyunAciklama.setText("Kaybettin!..")
                self.oyunBasladi = False
            elif self.board[3]=="" and self.board[6]==self.bilgIsaret and self.board[9]==self.bilgIsaret:
                self.btn3.setText(self.bilgIsaret)
                self.lblOyunAciklama.setText("Kaybettin!..")
                self.oyunBasladi = False
            elif self.board[4]=="" and self.board[1]==self.bilgIsaret and self.board[7]==self.bilgIsaret:
                self.btn4.setText(self.bilgIsaret)
                self.lblOyunAciklama.setText("Kaybettin!..")
                self.oyunBasladi = False
            elif self.board[4] == "" and self.board[5] == self.bilgIsaret and self.board[6] == self.bilgIsaret:
                self.btn4.setText(self.bilgIsaret)
                self.lblOyunAciklama.setText("Kaybettin!..")
                self.oyunBasladi = False
            elif self.board[5] == "" and self.board[2] == self.bilgIsaret and self.board[8] == self.bilgIsaret:
                self.btn5.setText(self.bilgIsaret)
                self.lblOyunAciklama.setText("Kaybettin!..")
                self.oyunBasladi = False
            elif self.board[5] == "" and self.board[4] == self.bilgIsaret and self.board[6] == self.bilgIsaret:
                self.btn5.setText(self.bilgIsaret)
                self.lblOyunAciklama.setText("Kaybettin!..")
                self.oyunBasladi = False
            elif self.board[5] == "" and self.board[7] == self.bilgIsaret and self.board[3] == self.bilgIsaret:
                self.btn5.setText(self.bilgIsaret)
                self.lblOyunAciklama.setText("Kaybettin!..")
                self.oyunBasladi = False
            elif self.board[5] == "" and self.board[1] == self.bilgIsaret and self.board[9] == self.bilgIsaret:
                self.btn5.setText(self.bilgIsaret)
                self.lblOyunAciklama.setText("Kaybettin!..")
                self.oyunBasladi = False
            elif self.board[6] == "" and self.board[4] == self.bilgIsaret and self.board[5] == self.bilgIsaret:
                self.btn6.setText(self.bilgIsaret)
                self.lblOyunAciklama.setText("Kaybettin!..")
                self.oyunBasladi = False
            elif self.board[6] == "" and self.board[3] == self.bilgIsaret and self.board[9] == self.bilgIsaret:
                self.btn6.setText(self.bilgIsaret)
                self.lblOyunAciklama.setText("Kaybettin!..")
                self.oyunBasladi = False
            elif self.board[7] == "" and self.board[1] == self.bilgIsaret and self.board[4] == self.bilgIsaret:
                self.btn7.setText(self.bilgIsaret)
                self.lblOyunAciklama.setText("Kaybettin!..")
                self.oyunBasladi = False
            elif self.board[7] == "" and self.board[3] == self.bilgIsaret and self.board[5] == self.bilgIsaret:
                self.btn7.setText(self.bilgIsaret)
                self.lblOyunAciklama.setText("Kaybettin!..")
                self.oyunBasladi = False
            elif self.board[7] == "" and self.board[8] == self.bilgIsaret and self.board[9] == self.bilgIsaret:
                self.btn7.setText(self.bilgIsaret)
                self.lblOyunAciklama.setText("Kaybettin!..")
                self.oyunBasladi = False
            elif self.board[8] == "" and self.board[2] == self.bilgIsaret and self.board[5] == self.bilgIsaret:
                self.btn8.setText(self.bilgIsaret)
                self.lblOyunAciklama.setText("Kaybettin!..")
                self.oyunBasladi = False
            elif self.board[8] == "" and self.board[7] == self.bilgIsaret and self.board[9] == self.bilgIsaret:
                self.btn8.setText(self.bilgIsaret)
                self.lblOyunAciklama.setText("Kaybettin!..")
                self.oyunBasladi = False
            elif self.board[9] == "" and self.board[1] == self.bilgIsaret and self.board[5] == self.bilgIsaret:
                self.btn9.setText(self.bilgIsaret)
                self.lblOyunAciklama.setText("Kaybettin!..")
                self.oyunBasladi = False
            elif self.board[9] == "" and self.board[7] == self.bilgIsaret and self.board[8] == self.bilgIsaret:
                self.btn9.setText(self.bilgIsaret)
                self.lblOyunAciklama.setText("Kaybettin!..")
                self.oyunBasladi = False
            elif self.board[9] == "" and self.board[3] == self.bilgIsaret and self.board[6] == self.bilgIsaret:
                self.btn9.setText(self.bilgIsaret)
                self.lblOyunAciklama.setText("Kaybettin!..")
                self.oyunBasladi = False
            else:
                self.kazanmaEngelle()
    def bilgisayarHamleYap(self):
        self.board=["_",self.btn1.text(),self.btn2.text(),self.btn3.text(),
                        self.btn4.text(),self.btn5.text(),self.btn6.text(),
                        self.btn7.text(),self.btn8.text(),self.btn9.text()]

        self.kazananHamleYap()
        if self.oyunBasladi:
            self.lblOyunAciklama.setText("İşaretiniz: "+self.isaret+" Devam!")




    def hamle1(self):
        if self.oyunBasladi and self.btn1.text()=="":
            self.btn1.setText(self.isaret)
            if self.btn2.text()==self.isaret and self.btn3.text()==self.isaret:
                self.lblOyunAciklama.setText("Kazandınız!..")
                self.oyunBasladi=False
            elif self.btn4.text()==self.isaret and self.btn7.text()==self.isaret:
                self.lblOyunAciklama.setText("Kazandınız!..")
                self.oyunBasladi=False
            elif self.btn5.text()==self.isaret and self.btn9.text()==self.isaret:
                self.lblOyunAciklama.setText("Kazandınız!..")
                self.oyunBasladi=False

            self.bilgisayarHamleYap()

    def hamle2(self):
        if self.oyunBasladi and self.btn2.text()=="":
            self.btn2.setText(self.isaret)
            if self.btn1.text() == self.isaret and self.btn3.text() == self.isaret:
                self.lblOyunAciklama.setText("Kazandınız!..")
                self.oyunBasladi = False
            elif self.btn5.text() == self.isaret and self.btn8.text() == self.isaret:
                self.lblOyunAciklama.setText("Kazandınız!..")
                self.oyunBasladi = False

            self.bilgisayarHamleYap()

    def hamle3(self):
        if self.oyunBasladi and self.btn3.text()=="":
            self.btn3.setText(self.isaret)
            if self.btn6.text()==self.isaret and self.btn9.text()==self.isaret:
                self.lblOyunAciklama.setText("Kazandınız!..")
                self.oyunBasladi=False
            elif self.btn5.text()==self.isaret and self.btn7.text()==self.isaret:
                self.lblOyunAciklama.setText("Kazandınız!..")
                self.oyunBasladi=False
            elif self.btn1.text()==self.isaret and self.btn2.text()==self.isaret:
                self.lblOyunAciklama.setText("Kazandınız!..")
                self.oyunBasladi=False

            self.bilgisayarHamleYap()

    def hamle4(self):
        if self.oyunBasladi and self.btn4.text()=="":
            self.btn4.setText(self.isaret)
            if self.btn1.text()==self.isaret and self.btn7.text()==self.isaret:
                self.lblOyunAciklama.setText("Kazandınız!..")
                self.oyunBasladi=False
            elif self.btn5.text()==self.isaret and self.btn6.text()==self.isaret:
                self.lblOyunAciklama.setText("Kazandınız!..")
                self.oyunBasladi=False

            self.bilgisayarHamleYap()

    def hamle5(self):
        if self.oyunBasladi and self.btn5.text()=="":
            self.btn5.setText(self.isaret)
            if self.btn2.text()==self.isaret and self.btn8.text()==self.isaret:
                self.lblOyunAciklama.setText("Kazandınız!..")
                self.oyunBasladi=False
            elif self.btn4.text()==self.isaret and self.btn6.text()==self.isaret:
                self.lblOyunAciklama.setText("Kazandınız!..")
                self.oyunBasladi=False
            elif self.btn3.text()==self.isaret and self.btn7.text()==self.isaret:
                self.lblOyunAciklama.setText("Kazandınız!..")
                self.oyunBasladi=False
            elif self.btn1.text()==self.isaret and self.btn9.text()==self.isaret:
                self.lblOyunAciklama.setText("Kazandınız!..")
                self.oyunBasladi=False

            self.bilgisayarHamleYap()

    def hamle6(self):
        if self.oyunBasladi and self.btn6.text()=="":
            self.btn6.setText(self.isaret)
            if self.btn4.text()==self.isaret and self.btn5.text()==self.isaret:
                self.lblOyunAciklama.setText("Kazandınız!..")
                self.oyunBasladi=False
            elif self.btn3.text()==self.isaret and self.btn9.text()==self.isaret:
                self.lblOyunAciklama.setText("Kazandınız!..")
                self.oyunBasladi=False

            self.bilgisayarHamleYap()

    def hamle7(self):
        if self.oyunBasladi and self.btn7.text()=="":
            self.btn7.setText(self.isaret)
            if self.btn1.text()==self.isaret and self.btn4.text()==self.isaret:
                self.lblOyunAciklama.setText("Kazandınız!..")
                self.oyunBasladi=False
            elif self.btn3.text()==self.isaret and self.btn5.text()==self.isaret:
                self.lblOyunAciklama.setText("Kazandınız!..")
                self.oyunBasladi=False
            elif self.btn8.text()==self.isaret and self.btn9.text()==self.isaret:
                self.lblOyunAciklama.setText("Kazandınız!..")
                self.oyunBasladi=False

            self.bilgisayarHamleYap()

    def hamle8(self):
        if self.oyunBasladi and self.btn8.text()=="":
            self.btn8.setText(self.isaret)
            if self.btn2.text()==self.isaret and self.btn5.text()==self.isaret:
                self.lblOyunAciklama.setText("Kazandınız!..")
                self.oyunBasladi=False
            elif self.btn7.text()==self.isaret and self.btn9.text()==self.isaret:
                self.lblOyunAciklama.setText("Kazandınız!..")
                self.oyunBasladi=False

            self.bilgisayarHamleYap()

    def hamle9(self):
        if self.oyunBasladi and self.btn9.text()=="":
            self.btn9.setText(self.isaret)
            if self.btn7.text()==self.isaret and self.btn8.text()==self.isaret:
                self.lblOyunAciklama.setText("Kazandınız!..")
                self.oyunBasladi=False
            elif self.btn1.text()==self.isaret and self.btn5.text()==self.isaret:
                self.lblOyunAciklama.setText("Kazandınız!..")
                self.oyunBasladi=False
            elif self.btn3.text()==self.isaret and self.btn6.text()==self.isaret:
                self.lblOyunAciklama.setText("Kazandınız!..")
                self.oyunBasladi=False

            self.bilgisayarHamleYap()
    def oyunaBasla(self):
        self.btn1.setText("")
        self.btn2.setText("")
        self.btn3.setText("")
        self.btn4.setText("")
        self.btn5.setText("")
        self.btn6.setText("")
        self.btn7.setText("")
        self.btn8.setText("")
        self.btn9.setText("")

        if self.isaret==None:
            self.lblOyunAciklama.setText("İşaret Seçiniz!..")
        else:
            self.oyunBasladi=True

            kura=random.randint(0,1)
            if kura==0:
                self.lblOyunAciklama.setText("İlk Bilgisayar Başlıyor...")
                self.bilgisayarHamleYap()
            else:
                self.lblOyunAciklama.setText("İşaretiniz: " + self.isaret + " Devam!")
    def isaretXyap(self):
        if not self.oyunBasladi:
            self.isaret="X"
            self.bilgIsaret = "O"
            self.lblOyunAciklama.setText("İşaretiniz: X")
        else:
            self.lblOyunAciklama.setText("Oyun Başladi!..")
    def isaretOyap(self):
        if not self.oyunBasladi:
            self.isaret="O"
            self.bilgIsaret = "X"
            self.lblOyunAciklama.setText("İşaretiniz: O")
        else:
            self.lblOyunAciklama.setText("Oyun Başladı!..")
    def retranslateUi(self, Form):
        _translate = QtCore.QCoreApplication.translate
        Form.setWindowTitle(_translate("Form", "Tic Tac Toe"))
        self.btnOyunaBasla.setText(_translate("Form", "Oyuna Başla"))
        self.lblOyunAciklama.setText(_translate("Form", "Oyuna Başalayabilirsiniz!.."))
        self.label_2.setText(_translate("Form", "İşaretinizi  Seciçiniz"))
        self.btnIsaretO.setText(_translate("Form", "O"))
        self.btnIsaretX.setText(_translate("Form", "X"))
        self.label.setText(_translate("Form", "Tic Tac Toe\'ya Hoşgeldiniz!"))



if __name__ == "__main__":
    app = QtWidgets.QApplication(sys.argv)
    Form = QtWidgets.QWidget()
    ui = Ui_Form()
    ui.setupUi(Form)
    Form.show()
    sys.exit(app.exec_())