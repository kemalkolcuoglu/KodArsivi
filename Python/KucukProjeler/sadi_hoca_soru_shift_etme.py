l = [1,2,3,4]
print(l)
for i in l:
  l.append(l[3]+1)
  l.pop(0)
  print(l)
