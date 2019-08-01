void setup() {
  pinMode(2,OUTPUT);
  pinMode(3,OUTPUT);
}

void loop() {
  int count = 0;
  Serial.begin(9600);
  Serial.println("Led Yanar");
  while(1)
  {
    digitalWrite(2,HIGH);
    digitalWrite(3,LOW);
    delay(500);
    digitalWrite(2,LOW);
    digitalWrite(3,HIGH);
    delay(500);
    count++;
    if(count==10)
    {
      digitalWrite(2,HIGH);
      digitalWrite(3,HIGH);
      delay(3000);
      count = 0;
    }
    
  }
}
