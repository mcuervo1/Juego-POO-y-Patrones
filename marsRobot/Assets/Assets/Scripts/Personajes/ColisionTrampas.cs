using UnityEngine;
using System.Collections;

public class ColisionTrampas : MonoBehaviour {
    public double timeSpan = 1.0d;
    private double elapsedTime = 0.0d;
    private ArrayList traps;

    void Start() 
    {
        traps = new ArrayList();
    }

    void Update()
    {
        if (elapsedTime > timeSpan)
        {
            applyDamage(traps.Count);
            elapsedTime = 0.0d;
        }
        else 
        {
            elapsedTime += Time.deltaTime;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Trap") {
            traps.Add(other.gameObject);
        }    
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Trap")
        {
            traps.Remove(other.gameObject);
        }
    }

    private void applyDamage(int numTraps) {
        throw new System.NotImplementedException();
    }
}
