using UnityEngine;
using System.Collections;

/* Probablemente sea necesario separar en dos Scripts ya que el emparentamiento
   quiza haga que los hijos de la sierra se muevan*/

public class Sierra : MonoBehaviour {
    
    private ArrayList puntos;
    private int index = 0;
    public float speed = 0.0f;

    void Awake() {
        puntos = new ArrayList();
    }

    void Start() {
        int count = transform.GetChildCount();
        for (int i = 0; i < count; i++) {
            puntos.Add(transform.GetChild(i).position);
        }
    }

	// Update is called once per frame
	void Update () {
        if (transform.position == (Vector3)puntos[index])
        {
            index = (index == puntos.Count) ? 0 : index++;
        }
        else 
        {
            Vector3 displacement = ((Vector3)puntos[index] - transform.position)*speed;
            transform.position += displacement;
        }
	}
}
