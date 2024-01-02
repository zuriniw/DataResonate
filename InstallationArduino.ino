const int motorPin = 3; // Motor vibrator connected to digital pin 3
const int redPin = 9; // Red LED pin
const int greenPin = 10; // Green LED pin
const int bluePin = 11; // Blue LED pin
const int AtomizerPIN1 = 4; // Define pin number 4 for Atomizer 1 (single head)
const int AtomizerPIN2 = 2; // Define pin number 2 for Atomizer 2 (double head)

void setColor(int red, int green, int blue) {
  analogWrite(redPin, red);
  analogWrite(greenPin, green);
  analogWrite(bluePin, blue);
}

void setup() {
  Serial.begin(115200);
  pinMode(AtomizerPIN1, OUTPUT);
  pinMode(AtomizerPIN2, OUTPUT);
  pinMode(motorPin, OUTPUT);
  pinMode(redPin, OUTPUT);
  pinMode(greenPin, OUTPUT);
  pinMode(bluePin, OUTPUT);
  analogWrite(motorPin, 0);
  setColor(255, 255, 255); // Initial state is white
}

// Functions
void offAllAtomizer(){
   digitalWrite(AtomizerPIN1, LOW); // Output LOW level, Relay module 1 disconnected
   digitalWrite(AtomizerPIN2, LOW); // Output LOW level, Relay module 2 disconnected
}

void on1atomizer(){ // Turn on 1 atomizer head
   digitalWrite(AtomizerPIN2, LOW); // Output LOW level, Relay module 2 disconnected
   digitalWrite(AtomizerPIN1, HIGH); // Output HIGH level, Relay module 1 connected
}

void on2atomizer(){ // Turn on 2 atomizer heads
   digitalWrite(AtomizerPIN1, LOW); // Output LOW level, Relay module 1 disconnected
   digitalWrite(AtomizerPIN2, HIGH); // Output HIGH level, Relay module 2 connected
}

void on3atomizer(){ // Turn on 3 atomizer heads
    digitalWrite(AtomizerPIN2, HIGH); // Output HIGH level, Relay module 2 connected
    delay(0);
    digitalWrite(AtomizerPIN1, HIGH); // Output HIGH level, Relay module 1 connected
}

// Loop
void loop() {
  if (Serial.available()) {
    char X = Serial.read();

    if (X == 'C') {
      analogWrite(motorPin, 255); // Vibrate the motor at maximum intensity
      setColor(255, 20, 0); // Set to red
      on3atomizer(); // Three-speed atomization
      delay(2000);
      analogWrite(motorPin, 0);
      setColor(20, 25, 25); // Restore to white
      offAllAtomizer(); // Turn off the atomizer
    }

    if (X == 'V') {
      analogWrite(motorPin, 195);
      setColor(255, 100, 0); // Set to pink
      on2atomizer(); // Two-speed atomization
      delay(2000);
      analogWrite(motorPin, 0);
      setColor(20, 25, 25); // Restore to white
      offAllAtomizer(); // Turn off the atomizer
    }

    if (X == 'B') {
      analogWrite(motorPin, 150); // One-speed motor
      setColor(255, 140, 20); // Set to pale pink
      on1atomizer(); // One-speed atomization
      delay(2000);
      analogWrite(motorPin, 0); // Turn off the motor
      setColor(20, 25, 25); // Restore to white
      offAllAtomizer(); // Turn off the atomizer
    }
  }
  delay(100);
}
