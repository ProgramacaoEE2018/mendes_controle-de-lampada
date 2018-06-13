char estado_botao = 0;
int tempo;

void setup()
{
 pinMode(4,OUTPUT);   //define a porta 4 como sa�da
 digitalWrite(4,LOW); //inicializa o estado da porta 4 como desligado
 Serial.begin(9600);  //inicializa a comunicacao com o pc em uma velocidade de 9600 Mbps
}

void loop()
{
 if(Serial.available() > 0)         //verifica se ha dados para serem lidos (ou seja, se o usuaro executou um comando)
 {
  estado_botao = Serial.read();      //l� o comando do usuario
  if(estado_botao == '1')            //se o usuario aperta o botao "liga"
   digitalWrite(4,HIGH);             //acende a lampada
  if(estado_botao == '0')            //se o usuario aperta o botao "desliga"
   digitalWrite(4,LOW);              //desliga a lampada
  if(Serial.read() > 999)            //l� o comando do tempo, que deve ser maior que 1s(1000 ms) 
   delay(Serial.read());             //d� o intervalo de tempo lido
}
}