using UnityEngine;
using System.Collections;

public class Creador : MonoBehaviour {

    public Transform Cubo1, Cubo2, Esfera1, Esfera2;

	// Use this for initialization
	void Start () {

        Cubo1.gameObject.SetActive(false);
        Cubo2.gameObject.SetActive(false);
        Esfera1.gameObject.SetActive(false);
        Esfera2.gameObject.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.A))
        {
            Cubo1.gameObject.SetActive(true);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Cubo2.gameObject.SetActive(true);
        }

        if (Input.GetKey(KeyCode.Z))
        {
            Esfera1.gameObject.SetActive(true);
        }

        if (Input.GetKey(KeyCode.X))
        {
            Esfera2.gameObject.SetActive(true);
        }
	}

    public void CargarMundo()
    {
        Application.LoadLevel("Mundo");
    }
}
