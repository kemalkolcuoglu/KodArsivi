#include <QTRSensors.h>

//=============================================================
//motor A connected between A01 and A02
//motor B connected between B01 and B02

int STBY = 10; //standby

//Motor A
int PWMA = 3; //Speed control 
int AIN1 = 9; //Direction
int AIN2 = 8; //Direction

//Motor B
int PWMB = 5; //Speed control
int BIN1 = 11; //Direction
int BIN2 = 12; //Direction
//=============================================================
#define NUM_SENSORS 6 // Sensor sayisi
#define NUM_SAMPLES_PER_SENSOR 4
#define EMITTER_PIN 4  //Pin degisecek

QTRSensorsAnalog qtra((unsigned char[]){0, 1, 2, 3, 4, 5},NUM_SENSORS,NUM_SAMPLES_PER_SENSOR,EMITTER_PIN);
unsigned int sensorValues[NUM_SENSORS]; // Sensorun okudugu degerler
unsigned int position;
//=============================================================
const int trig = 2; //2. Pine bagli ses gonderen baslik
const int echo = 3; //3. Pine bagli ses alan baslik
//=============================================================
bool zemin;
int hc_sayac = 0;     //
int engel_sayac = 0;
int cizgi_sayac = 0;  //
int sure = 0;         // HC icin sure tutan degisken
int mesafe = 0;       // HC icin mesafe olcen degisken
//=============================================================
void setup()
{  
  pinMode(trig,OUTPUT); // Ses gonderilecegi icin output deger alir
  pinMode(echo,INPUT);  // Ses algilanacagi icin input deger alir
//==============================================================
  pinMode(STBY, OUTPUT);
  pinMode(PWMA, OUTPUT); //Motor surucusunun degiskenleri
  pinMode(AIN1, OUTPUT);
  pinMode(AIN2, OUTPUT);
  pinMode(PWMB, OUTPUT);
  pinMode(BIN1, OUTPUT);
  pinMode(BIN2, OUTPUT);
//===============================================================
  //QTR_SENSOR SETUP KODLARI
  Serial.begin(9600);
  delay(500);
  int i;
  pinMode(13, OUTPUT);
  digitalWrite(13, HIGH);
  for (i = 0; i < 400; i++)
  {
    qtra.calibrate();
  }
  digitalWrite(13, LOW);
  for (i = 0; i < NUM_SENSORS; i++)
  {
    Serial.print(qtra.calibratedMinimumOn[i]);
    Serial.print(' ');
  }
  Serial.println();
  for (i = 0; i < NUM_SENSORS; i++)
  {
    Serial.print(qtra.calibratedMaximumOn[i]);
    Serial.print(' ');
  }
  Serial.println();
  Serial.println();
  delay(1000);
}
//===============================================================
void loop()
{
  baslangic();
  hc_sensor();
  while(1)
  {
    if(sensorValues[0]<100 && sensorValues[5]<100)
      zemin=0;
    else if(sensorValues[0]>500 && sensorValues[5]>500)
      zemin=1;  
    position = qtra.readLine(sensorValues);
    if(position > 2250 && position < 2550)
      ilerleme();
    /*else if(sensorValue[2]==LOW && sensorValue[3]==LOW)
    {
      if(zemin==1)
      {
        beyaz_alan();
      }
    }*/
    else
    {
      hc_kontrol();
      if(position == 0)
      {
        move(1,32,0);
        move(2,32,0);
      }
      else if(position == 5000)
      {
        cizgi_sayac++;
        if(cizgi_sayac == 4)
        {
          saga_donus();
        }
      }
      else if(position < 2250)
      {
        if(hc_sayac==4)
          kisa_yol();
        else
          saga_donus();
      }
      else if(position > 2550)
      {
        sola_donus();
      }
    }
  }
}

void ilerleme()
{
  move(1,128,0); //motor 1, half speed, forward
  move(2,128,0); //motor 2, half speed, forward
}

void baslangic()
{
  if(position >= 3000)//Sensorler fazla deger gormesi durumu
  {
      sola_donus();
  }
}

void kisa_yol()
{
  hc_sayac = 0;
  engel_sayac = 0;
  if(cizgi_sayac!=4)
  {
    //Ufak bir ilerleme
    cizgi_sayac+=1;
  }
  else
    saga_donus();
}

void hc_kontrol()
{
  if(hc_sayac==4)
    saga_donus();
  else if(mesafe==2)
  {
    engel_sayac++;
    if(engel_sayac==1)
      saga_donus();
    else if(engel_sayac==2)
      sola_donus();
  }
}

void saga_donus()
{
  //Sağ teker geri Sol teker ileri
  move(1,16,1);
  move(2,64,0);
}

void sola_donus()
{
  //Sol teker geri Sağ teker ileri
  move(1,64,0);
  move(2,16,1);
}

void hc_sensor()
{
  digitalWrite(trig, HIGH);
  delayMicroseconds(1000);
  digitalWrite(trig, LOW);
  sure = pulseIn(echo, HIGH);
  mesafe = (sure/2) / 29.1;
  if(mesafe == 3)
    hc_sayac++;
  Serial.print("Mesafe: ");
  Serial.print(mesafe);
  Serial.println(" cm");
  delay(250);
}
//=====================================================
void move(int motor, int speed, int direction)
{
//Move specific motor at speed and direction
//motor: 0 for B 1 for A
//speed: 0 is off, and 255 is full speed
//direction: 0 clockwise, 1 counter-clockwise, 2 forward

  digitalWrite(STBY, HIGH); //disable standby

  boolean inPin1 = LOW;
  boolean inPin2 = HIGH;

  if(direction == 1)
  {
    inPin1 = HIGH;
    inPin2 = LOW;
  }

  if(motor == 1)
  {
    digitalWrite(AIN1, inPin1);
    digitalWrite(AIN2, inPin2);
    analogWrite(PWMA, speed);
  }
  else
  {
    digitalWrite(BIN1, inPin1);
    digitalWrite(BIN2, inPin2);
    analogWrite(PWMB, speed);
  }
}

void stop()
{
//enable standby  
  digitalWrite(STBY, LOW); 
}
