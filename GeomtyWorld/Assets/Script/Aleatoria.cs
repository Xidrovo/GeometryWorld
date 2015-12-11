using UnityEngine;
using System.Collections;

public class Aleatoria : MonoBehaviour {

    private float Time;
    private float TimeOut = 1;
    private bool Entro = true;

	// Use this for initialization
	void Start () {
//        InvokeRepeating("Cambio", 0, TimeOut);
	}

    void Update()
    {
        if (Entro)
        {
            Entro = false;
            Invoke("Cambio", TimeOut);
        }
    }
    void Cambio()
    {
        TimeOut = Random.Range(8, 12);
        Debug.Log("he he hey~");
        transform.position = new Vector3(Random.Range(-10, 10), transform.position.y, 0);
        Entro = true;
    }
}
