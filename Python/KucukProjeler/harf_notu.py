vize1 = int(input("Birinci Vizeyi Giriniz : "))
vize2 = int(input("İkinci Vizeyi Giriniz : "))
final = int(input("Final Notunuzu Giriniz : "))

ynot = (vize1*0.3+vize2*0.3+final*0.4)

if ynot >= 90 :
    print("Harf Notunuz : AA")
elif ynot >= 85 :
    print("Harf Notunuz : BA")
elif ynot >= 80 :
    print("Harf Notunuz : BB")
elif ynot >= 75 :
    print("Harf Notunuz : CB")
elif ynot >= 70 :
    print("Harf Notunuz : CC")
elif ynot >= 65 :
    print("Harf Notunuz : DC")
elif ynot >= 60 :
    print("Harf Notunuz : DD")
elif ynot >= 55 :
    print("Harf Notunuz : FD")
else:
    print("Harf Notunuz : FF")
print("Notunuz :",ynot)
