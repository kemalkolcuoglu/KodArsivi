# http://ysar.net/python/threading-vs-multiprocessing.html
# Bu siteden alınmış bir örnek

from threading import Thread
from random import randint
from time import sleep

def basvuru(basvuru_id):
    sleep(randint(0, 60))
    if randint(0, 1):
        print("{} başvurusu kabul edildi.".format(basvuru_id))
    else:
        print("{} başvurusu reddedildi.".format(basvuru_id))


for i in range(1, 5):
    Thread(target=basvuru, args=(i, )).start()
