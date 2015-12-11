using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {


    public float Speed = 5f;
    public Transform Punto;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.Translate(new Vector3(Punto.transform.position.x, this.transform.position.y, 0) 
            * Speed * Time.deltaTime);
	}
}
