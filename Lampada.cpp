void setup()
{
 pinMode(4,OUTPUT);   //define a porta 4 como saída
 digitalWrite(4,LOW); //inicializa o estado da porta 4 como desligado
 Serial.begin(9600);  //inicializa a comunicacao com o pc em uma velocidade de 9600 Mbps
}

void loop()
{
 char comando = 0;
 
 
 if(Serial.available() > 0)         //verifica se ha dados para serem lidos (ou seja, se o usuaro executou um comando)
  comando = Serial.read();     //lê o comando do usuario
 if(comando == '1')            //se o usuario aperta o botao "liga"
 { 
  digitalWrite(4,HIGH);            //acende a lampada
 }
 if(comando == '3')           //desliga daqui a 5s
 {
  delay(5000);
  digitalWrite(4,LOW);
 }
 if(comando == '5')           //desliga daqui a 10 min
 {
  delay(600000);
  digitalWrite(4,LOW);
 }
 if(comando == '7')           //desliga daqui a 1 h
 {
  delay(3600000);
  digitalWrite(4,LOW);
 }
 if(comando == '0')            //se o usuario aperta o botao "desliga"
 {
  digitalWrite(4,LOW);              //desliga a lampada
 }
 if(comando == '2')           //liga daqui a 5s
 {
  delay(5000);
  digitalWrite(4,HIGH);
 }
 if(comando == '4')           //liga daqui a 10 min
 {
  delay(600000);
  digitalWrite(4,HIGH);
 }
 if(comando == '6')           //liga daqui a 1 h
 {
  delay(3600000);
  digitalWrite(4,HIGH);
 }
}
