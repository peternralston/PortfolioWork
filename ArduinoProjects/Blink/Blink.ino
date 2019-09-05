int RED_LED = 12;
int YELLOW_LED = 11;
int BLUE_LED = 10;

int counter=0;

void setup() {
  // initialize digital pin LED as an output.
  // LED_BUILTIN
  pinMode(RED_LED, OUTPUT);
  pinMode(YELLOW_LED, OUTPUT);
  pinMode(BLUE_LED, OUTPUT);

  digitalWrite(RED_LED, LOW);
  digitalWrite(YELLOW_LED, LOW);
  digitalWrite(BLUE_LED, LOW);
  
  Serial.begin(9600);
}

void loop() {
//  counter = counter + 1;
//  Serial.print("Blink Number # ");
//  Serial.println(counter);

// Yield Mode
  digitalWrite(RED_LED, LOW);
  digitalWrite(YELLOW_LED, HIGH);
  digitalWrite(BLUE_LED, LOW);

  Serial.println(" Light Mode : Yield ");
  delay(1000);

// Go Mode
  digitalWrite(RED_LED, LOW);
  digitalWrite(YELLOW_LED, LOW);
  digitalWrite(BLUE_LED, HIGH);

  Serial.println(" Light Mode : Go ");
  delay(1000);

// Stop Mode
  digitalWrite(RED_LED, HIGH);
  digitalWrite(YELLOW_LED, LOW);
  digitalWrite(BLUE_LED, LOW);

  Serial.println(" Light Mode : Stop ");
  delay(1000);
}
