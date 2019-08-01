VERSION 5.00
Object = "{6BF52A50-394A-11D3-B153-00C04F79FAA6}#1.0#0"; "wmp.dll"
Object = "{8E27C92E-1264-101C-8A2F-040224009C02}#7.0#0"; "MSCAL.OCX"
Object = "Excel.Sheet.12"; "EXCEL.EXE"
Begin VB.Form KolcuogluNet 
   Caption         =   "KolcuogluNet"
   ClientHeight    =   13530
   ClientLeft      =   225
   ClientTop       =   855
   ClientWidth     =   14670
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   9.75
      Charset         =   162
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   13530
   ScaleWidth      =   14670
   StartUpPosition =   3  'Windows Default
   WhatsThisButton =   -1  'True
   WhatsThisHelp   =   -1  'True
   Begin VB.VScrollBar VScroll1 
      Height          =   13455
      Left            =   14400
      TabIndex        =   3
      Top             =   0
      Width           =   255
   End
   Begin MSACAL.Calendar Takvim 
      Height          =   3735
      Left            =   5400
      TabIndex        =   0
      Top             =   3360
      Width           =   3735
      _Version        =   524288
      _ExtentX        =   6588
      _ExtentY        =   6588
      _StockProps     =   1
      BackColor       =   -2147483633
      Year            =   2011
      Month           =   2
      Day             =   20
      DayLength       =   1
      MonthLength     =   0
      DayFontColor    =   0
      FirstDay        =   1
      GridCellEffect  =   1
      GridFontColor   =   10485760
      GridLinesColor  =   -2147483632
      ShowDateSelectors=   -1  'True
      ShowDays        =   -1  'True
      ShowHorizontalGrid=   -1  'True
      ShowTitle       =   -1  'True
      ShowVerticalGrid=   -1  'True
      TitleFontColor  =   10485760
      ValueIsNull     =   0   'False
      BeginProperty DayFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial Tur"
         Size            =   8.25
         Charset         =   162
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty GridFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial Tur"
         Size            =   8.25
         Charset         =   162
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty TitleFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial Tur"
         Size            =   12
         Charset         =   162
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin VB.Image Logo 
      Height          =   2715
      Left            =   -120
      Picture         =   "Kolcuoglu EXE.frx":0000
      Top             =   120
      Width           =   14280
   End
   Begin WMPLibCtl.WindowsMediaPlayer WindowsMediaPlayer1 
      Height          =   3135
      Left            =   5280
      TabIndex        =   2
      Top             =   7440
      Width           =   3855
      URL             =   ""
      rate            =   1
      balance         =   0
      currentPosition =   0
      defaultFrame    =   ""
      playCount       =   1
      autoStart       =   -1  'True
      currentMarker   =   0
      invokeURLs      =   -1  'True
      baseURL         =   ""
      volume          =   50
      mute            =   0   'False
      uiMode          =   "full"
      stretchToFit    =   0   'False
      windowlessVideo =   0   'False
      enabled         =   -1  'True
      enableContextMenu=   -1  'True
      fullScreen      =   0   'False
      SAMIStyle       =   ""
      SAMILang        =   ""
      SAMIFilename    =   ""
      captioningID    =   ""
      enableErrorDialogs=   0   'False
      _cx             =   6800
      _cy             =   5530
   End
   Begin ExcelCtl.Sheet Sheet1 
      Height          =   7530
      Left            =   360
      OleObjectBlob   =   "Kolcuoglu EXE.frx":13459
      TabIndex        =   1
      Top             =   3360
      Width           =   4575
   End
   Begin VB.Menu File 
      Caption         =   "Kolcuoglu.Net"
   End
End
Attribute VB_Name = "KolcuogluNet"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()

End Sub
