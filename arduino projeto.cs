// Código de Funcionamento para Sistema de Monitoramento e Irrigação com Arduino
 
#define pinoAnalog A0 // Define o pino A0 como "pinoAnalog"
#define pinoRele 8 // Define o pino 8 como "pinoRele"
#define pino5V 7 // Define o pino 7 como "pino5V"
 
int ValAnalogIn; // Introduz o valor analógico ao código
 
void setup() {
Serial.begin(9600); // Declara o BaundRate em 9600
pinMode(pinoRele, OUTPUT); // Declara o pinoRele como Saída
pinMode(pino5V, OUTPUT); // Declara o pino5V como Saída
digitalWrite(pino5V, HIGH); // Põem o pino5V em estado Alto = 5V
}
 
void loop() {
ValAnalogIn = analogRead(pinoAnalog); // Relaciona o valor analógico com o recebido do sensor
int Porcento = map(ValAnalogIn, 1023, 0, 0, 100); // Relaciona o valor analógico à porcentagem
 
if (Porcento <= 45) { // Se a porcentagem for menor ou igual à
digitalWrite(pinoRele, HIGH); // Altera o estado do pinoRele para nível Alto
}
 
else { // Se não ...
digitalWrite(pinoRele, LOW); // Altera o estado do pinoRele para nível Baixo
}
delay (1000); // Estabelece o tempo de 1s para reinicializar a leitura
}