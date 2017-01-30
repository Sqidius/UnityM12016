using UnityEngine;
using System.Collections;

public class triggerplayer : MonoBehaviour {

    public BasicAi fee;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("fee"))
        {
            fee.stop();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("fee"))
        {
            fee.go();
        }
    }
}
