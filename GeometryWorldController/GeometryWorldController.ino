//Programación para GeometryWorld v 0.1, prototipo para el parque Aja.

  int X;
  const int Salida = 4;
  const int Entrada = 6;
  
void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(Salida, OUTPUT);
//  pinMode(Entrada,INPUT);
  int X = 0;
}

void loop() {
  // put your main code here, to run repeatedly:
  digitalWrite(Salida, HIGH);
  X = analogRead(Entrada);
  Serial.print( X );
  Serial.print(" " + digitalRead(Salida));
  Serial.flush();
  delay(250);
  digitalWrite(Salida, LOW);
  //Serial(25);
  X++;
  delay(1000);
}

    /*
          SerialPort Puerto = new SerialPort ("COM3", 115200);

          void Start () 
  {
    try{
      Puerto.Open();
    }catch(System.Exception e)
    {
      values [0] = "0";
      values [1] = "0";
      values [2] = "0";
    }
  }

          void Update () 
  {
    Puerto.ReadTimeout = 25;
    if (Puerto.IsOpen) 
    {
      try 
      {
        UnzipMessage(Puerto.ReadLine());
//        Debug.Log (values[0] + "--" + values[1] + "--" + values[2]);
      }
      catch(System.Exception)
      {
        
      }
    }
  }

    */
