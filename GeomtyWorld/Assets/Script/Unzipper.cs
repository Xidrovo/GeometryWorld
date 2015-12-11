using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class Unzipper : MonoBehaviour {

  	SerialPort Puerto = new SerialPort ("COM3", 9600);

        	void Start () 
	{
		try{
			Puerto.Open();
		}catch(System.Exception e)
		{
            //Verificar si hay errores
		}
	}

        	void Update () 
	{
		Puerto.ReadTimeout = 25;
		if (Puerto.IsOpen) 
		{
			try 
			{
                //hacer acciones.
                Debug.Log(Puerto.ReadLine());
			}
			catch(System.Exception)
			{
//                Debug.Log("Something haaappeeend~");
			}
		}
	}
}
