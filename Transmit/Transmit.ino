int LED = 2; 
int SerialCom;

void setup() {
  Serial.begin(9600);  
  pinMode(LED, OUTPUT);
}

void loop() {
  if (Serial.available()) {
    SerialCom = Serial.read();
    if(SerialCom == '1'){
      digitalWrite(LED, HIGH);
    }
    else {
      digitalWrite(LED, LOW);
    }
  }
}
