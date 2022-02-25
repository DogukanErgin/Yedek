#define echoPin 6
#define trigPin 7
#define buzzerPin 8
int maximumRange = 500;
int minimumRange = 0;
long sure;
long mesafe;

void setup(){
pinMode(trigPin, OUTPUT);
pinMode(echoPin, INPUT);
pinMode(buzzerPin, OUTPUT);
Serial.begin(9600);

}

void loop(){

 int olcum = mesafefonk(maximumRange,minimumRange);
 melodi(olcum*10);
 Serial.println(mesafe);
 Serial.println("----cm----");
}
int mesafefonk(int maxrange,int minrange){
digitalWrite(trigPin,LOW);
delayMicroseconds(20000);
digitalWrite(trigPin,HIGH);
delayMicroseconds(100000);
digitalWrite(trigPin,LOW);

sure =pulseIn(echoPin,HIGH);
mesafe=sure / 58.2;
delay(50);

if(mesafe >= maxrange || mesafe <= minrange)
return 0;
return mesafe;
}
int melodi(int dly){
tone (buzzerPin,440);
delay(dly);
noTone(buzzerPin);
delay(dly);

}
