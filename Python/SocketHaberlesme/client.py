#from socket import AF_INET, SOCK_DGRAM
from socket import *
import time

print('Basladi') #Statement to let me know the program started correctly
serverName = '192.168.1.103' #server set as general computer ip
clientSocket = socket(AF_INET, SOCK_DGRAM) #create the socket
clientSocket.settimeout(2) #sets the timeout at 1 second
sequence_number = 1 #variable to keep track of the sequence number
pocket_lenght = 1024
lost_pocket = 0
suc_pocket = 0
while sequence_number<=6:
    message = 'Ping' #message to be sent
    start=time.time() #assigns the current time to a variable
    clientSocket.sendto(message,(serverName, 25400))#sends a message to the server on port 25400
    try:
        message, address = clientSocket.recvfrom(pocket_lenght) #recieves message from server
        elapsed = (time.time()-start) # calculates how much time has elapsed since the start time
        print sequence_number, '.', message, 'Iletilme Suresi :', str(elapsed), "saniye", "| Paket Boyutu ->", pocket_lenght   #issue with printing elapsed unless it was changed to a string
        suc_pocket += 1
    except: #if the socket takes longer that 1 second, it does the following instead of the try
        print(sequence_number)
        lost_pocket += 1
        print('Paket zaman asimina ugradi')
    sequence_number+=1 #sequence number is increased after all of the other statements in the while
    if sequence_number > 6: #closes the socket after 6 packets
        print "IP Adresi ->", serverName, "| Gonderilen Toplam Paket Sayisi ->", sequence_number-1, "| Iletilen Paket ->", suc_pocket, "| Kaybolan Paket ->", lost_pocket
        clientSocket.close()
