using UnityEngine;
using System.Collections;

public class Aleatoria : MonoBehaviour {

    private float Time;
    private float TimeOut = 1;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Cambio", 0, TimeOut);
	}

    void Cambio()
    {
        TimeOut = Random.Range(5, 10);
        transform.position = new Vector3(Random.Range(-13, 13), transform.position.y, 0);
    }
}
