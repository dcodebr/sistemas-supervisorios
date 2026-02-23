char rec[4];  //Variável que receberá os caracteres vindo da serial
int i = 0;    //Variável de índice de controle do rec
int ad;       //Variável de armazenamento da conversão A/D
boolean adc;  //Variável de controle de retorno da conversão A/D pela serial

//Variável para armazenamento da string a ser enviada para a serial
char ad_buffer[9];

//Armazena o último valor de tempo do dado enviado pela serial
unsigned long lastDateTime = 0;

//Tempo em ms desejado para o envio
const int dataInterval = 1000;

//Seleção do pino da entrada do trimPot
int sinalPin = A1;

void setup() {
  Serial.begin(9600);
}

void loop() {
  serialRead();

  if (adc) {
    //Armazena o tempo decorrido desde a execução
    unsigned long actualTime = millis();

    //Tempo decorrido
    unsigned long elapsedTime = actualTime - lastDateTime;

    if (elapsedTime >= dataInterval) {
      lastDateTime = actualTime;
      ad = analogRead(sinalPin);

      //Formata String AN0=0000
      snprintf(ad_buffer, sizeof(ad_buffer), "AN0=%04d", ad);
      Serial.println(ad_buffer);
    }
  }
}

//Esse evento do Serial já está assimilado pelo objeto
//Não precisa informar no loop
void serialRead() {
  while (Serial.available()) {
    rec[i] = (char)Serial.read();

    if (rec[i] == '\r') {
      i = 0;

      if ((rec[0] == 'I') && (rec[1] == 'N')) {
        Serial.println("INÍCIO");
        adc = true;
      }

      if ((rec[0] == 'F') && (rec[1] == 'N')) {
        Serial.println("FIM");
        adc = false;
      }

    } else {
      i++;
    }
  }
}
