#include <stdio.h>
#define VEZIRLER 8         /* vezir sayisi ve tahta boyu */
#define int unsigned       /* isaretsiz tamsayi kullan */

int sayi = 0;              /* cozum sayisi */
int tahta[VEZIRLER];       /* her eleman bir sirayi gosterir */

FILE *yaz;

/* tahtanin gecerliligini kontrol et */
int tahtaTamam (register int sira)             
{
	register int r;

	for (r = 0; r < sira; r++)  /* onceki tum siralari  kontrol et */
	if ((tahta[sira] == tahta[r]) ||   /*Aynz sütünda ise*/
		(tahta[sira] == (tahta[r] << (sira - r))) ||   /*saš eaprazznda ise*/
		(tahta[sira] == (tahta[r] >> (sira - r))))     /*sol eaprazznda ise*/
		return 0;             /* uyusmazlik varsa */
	return 1;                 /* uyusmazlik yoksa */
}

 void cozumyaz(void)        /* cozumu goster; sayiyi artir  */
 {
	 register int t, r;
	 
	 yaz = fopen("vezir.txt","a");
	 if( yaz == NULL)
	 {
	 	 puts("Dosya acilamiyor...");
	 }

	 fprintf(yaz, "\n\n\tCOZUM %u\n\n", ++sayi);
	 for (r = 0; r < VEZIRLER; r++)  /* sira */	
	   {
		 for (t = (1 << (VEZIRLER - 1)); t > 0; t >>= 1)
			 fprintf(yaz," %c", tahta[r] == t ? 'V' : '.');
		 fprintf(yaz,"\n");
	   }
 }

 void yerlestir(int sira)   /* bir sonraki siraya yerlestir  */
 {
	 if (sira == VEZIRLER)     /* tum siralar dolu ve kontrol  edilmis */
		 cozumyaz();
	 else
	 for (tahta[sira] = 1; tahta[sira]<(1 << VEZIRLER); tahta[sira] <<= 1)
	 if (tahtaTamam(sira))
		    yerlestir(sira + 1);  /* bir sonraki sirayi dene */
 }

 signed main(void)
 {
	 yerlestir(0);     /* ilk siradan basla */
	 fprintf(yaz, "\n\n%d vezir probleminin %u cozumu vardir.\n", VEZIRLER, sayi);
	 printf("8 Vezir Problemi Cozuldu...\n");
	 printf("Sonucu gormek icin vezir.txt dosyasina bakiniz.");
	 getch();
	 return 0;
 }
