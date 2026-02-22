char rec[4];
int i = 0;

void setup() {
  Serial.begin(9600);
  pinMode(13, OUTPUT);
}

void loop() {
  while (Serial.available()) {
    rec[i] = (char)Serial.read();

    if (rec[i] == '\r') { //#13 - CR
      i = 0;

      if ((rec[0] == 'L')
          && (rec[1] == 'L')
          && (rec[2] == '1')) {
        digitalWrite(13, HIGH);
      }

      if ((rec[0] == 'D')
          && (rec[1] == 'L')
          && (rec[2] == '1')) {
        digitalWrite(13, LOW);
      }

      Serial.print(rec);
    } else {
      i++;
    }
  }
}
