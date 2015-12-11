using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {


    public float Speed = 5f;
    public Transform Punto;
    Vector3 Vect;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vect = new Vector3(Punto.transform.position.x, this.transform.position.y, 0);
        transform.position = Vector3.MoveTowards(transform.position, Vect, 0.03f);
    }
}
