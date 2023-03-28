int LED = 3;
int TempSensor = A3;
int Receive;
void setup() {
  pinMode(LED,OUTPUT);
  Serial.begin(9600);
  
}

void loop() {
  Receive = analogRead(TempSensor);
  Serial.println(Receive);
  analogWrite(LED,Receive);
  delay(500);
}
