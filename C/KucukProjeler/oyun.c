#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <time.h>
#include <windows.h>

void imlec_konumu(int y, int x);
int tus_kontrol(void);
	
int main(void){
	int puan=0,hak=5,seviye=0,level;
	int yem_satir=2,yem_sutun=40,hiz=300;
	int box_satir=22,box_sutun=40,kutu_durum;
	while (yem_satir<23 && hak>0){
		if (!kbhit()) { 
			imlec_konumu(yem_satir,yem_sutun);printf(" ");
			if (yem_satir<18)
			  yem_sutun+=(rand()%9-4);
			if (yem_sutun<1)
			  yem_sutun=1;
			if (yem_sutun>78)
			  yem_sutun=78;
			imlec_konumu(yem_satir+=1,yem_sutun);printf("A");
			imlec_konumu(box_satir,0);printf("                                                                                ");
			imlec_konumu(box_satir,box_sutun);printf("|_____|");
			if (yem_satir==22) 
			  if ((box_sutun+1<=yem_sutun) && (yem_sutun<=box_sutun+5)) {
				imlec_konumu(box_satir,box_sutun);printf("|+++++|");
				puan=puan+50;
				seviye++;
			   	yem_satir=2;
				yem_sutun=40+(rand()%59-29);}
			  else {
				imlec_konumu(box_satir,box_sutun);printf("|~~~~~|");
			   	hak--;
				seviye++;
				yem_satir=2;
				yem_sutun=40+(rand()%59-29);}
			level=seviye/5;
			hiz=300-level*10;
			imlec_konumu(23,0);printf(" KutuKonum: %2d YemKonum: %2d Uzaklik: %2d Seviye: %2d Hiz: %3d Puan: %4d Hak: %2d",box_sutun,yem_sutun,21-yem_satir,level+1,320-hiz,puan,hak);
			Sleep(hiz);}
		else {
			kutu_durum=tus_kontrol();
			if (kutu_durum==-1)
		  		break;
			else if (kutu_durum==75)
		  		box_sutun-=4;
			else if (kutu_durum==77)
		  		box_sutun+=4;
	    	else;
		if (box_sutun<0)
		  box_sutun=0;
		if (box_sutun>72)
		  box_sutun=72;}
	}
	if (!hak)
	  {imlec_konumu(10,10);printf("Y E N I L D I N I Z.");}
	else
	  {imlec_konumu(10,10);printf("T E K R A R   G O R U S M E K   U Z E R E.");}
	return 0;}

void imlec_konumu(int y, int x){
  static HANDLE h = NULL;  
  if(!h)
    h = GetStdHandle(STD_OUTPUT_HANDLE);
  COORD c = { x, y };  
  SetConsoleCursorPosition(h,c);}

int tus_kontrol(void){
    int ch = getch();
    if (ch==27)
       return(-1);
    else if (ch == 0 || ch == 224)
       return ch;
    else; } 
