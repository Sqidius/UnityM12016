using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

    public string bName;
    public MapScript map;

    private ParticleSystem part;
    private bool isPlayerIn = false;
    private bool done = false;

	// Use this for initialization
	void Start () {
        part = GetComponent<ParticleSystem>();
        part.Stop();
	}
	
	// Update is called once per frame
	void Update () {
        TriggerTest();
	}

    public void Activate()
    {
        if(bName == "11" && !done)
        {
            map.ile11 = true;
            transform.Translate(0, 1.0f, 0.0f);
            part.Play();
            done = true;
        }

        if (bName == "12" && !done)
        {
            map.ile12 = true;
            transform.Translate(0, 1.0f, 0);
            part.Play();
            done = true;
        }

        if (bName == "13" && !done)
        {
            map.ile13 = true;
            transform.Translate(0, 1.0f, 0);
            part.Play();
            done = true;
        }

        if (bName == "14" && !done)
        {
            map.ile14 = true;
            transform.Translate(0, 1.0f, 0);
            part.Play();
            done = true;
        }

        if (bName == "15" && !done)
        {
            map.ile15 = true;
            transform.Translate(0, 1.0f, 0);
            part.Play();
            done = true;
        }

        if (bName == "16" && !done)
        {
            map.ile16 = true;
            transform.Translate(0, 1.0f, 0);
            part.Play();
            done = true;
        }

        if (bName == "21" && !done)
        {
            map.ile21 = true;
            transform.Translate(0, 1.0f, 0);
            part.Play();
            done = true;
        }

        if (bName == "22" && !done)
        {
            map.ile22 = true;
            transform.Translate(0, 1.0f, 0);
            part.Play();
            done = true;
        }

        if (bName == "23" && !done)
        {
            map.ile23 = true;
            transform.Translate(0, 1.0f, 0);
            part.Play();
            done = true;
        }

        if (bName == "24" && !done)
        {
            map.ile24 = true;
            transform.Translate(0, 1.0f, 0);
            part.Play();
            done = true;
        }

        if (bName == "25" && !done)
        {
            map.ile25 = true;
            transform.Translate(0, 1.0f, 0);
            part.Play();
            done = true;
        }

        if (bName == "31" && !done)
        {
            map.ile31 = true;
            transform.Translate(0, 1.0f, 0);
            part.Play();
            done = true;
        }

        if (bName == "32" && !done)
        {
            map.ile32 = true;
            transform.Translate(0, 1.0f, 0);
            part.Play();
            done = true;
        }

        if (bName == "33" && !done)
        {
            map.ile33 = true;
            transform.Translate(0, 1.0f, 0);
            part.Play();
            done = true;
        }

        if (bName == "34" && !done)
        {
            map.ile34 = true;
            transform.Translate(0, 1.0f, 0);
            part.Play();
            done = true;
        }

        if (bName == "35" && !done)
        {
            map.ile35 = true;
            transform.Translate(0, 1.0f, 0);
            part.Play();
            done = true;
        }

        if (bName == "36" && !done)
        {
            map.ile36 = true;
            transform.Translate(0, 1.0f, 0);
            part.Play();
            done = true;
        }

        if (bName == "37" && !done)
        {
            map.ile37 = true;
            transform.Translate(0, 1.0f, 0);
            part.Play();
            done = true;
        }

        if (bName == "38" && !done)
        {
            map.ile38 = true;
            transform.Translate(0, 1.0f, 0);
            part.Play();
            done = true;
        }

        if (bName == "41" && !done)
        {
            map.ile38 = true;
            transform.Translate(0, 1.0f, 0);
            part.Play();
            done = true;
        }

        if (bName == "42" && !done)
        {
            map.ile38 = true;
            transform.Translate(0, 1.0f, 0);
            part.Play();
            done = true;
        }

        if (bName == "43" && !done)
        {
            map.ile38 = true;
            transform.Translate(0, 1.0f, 0);
            part.Play();
            done = true;
        }

        if (bName == "44" && !done)
        {
            map.ile38 = true;
            transform.Translate(0, 1.0f, 0);
            part.Play();
            done = true;
        }

        if (bName == "45" && !done)
        {
            map.ile38 = true;
            transform.Translate(0, 1.0f, 0);
            part.Play();
            done = true;
        }

        if (bName == "46" && !done)
        {
            map.ile38 = true;
            transform.Translate(0, 1.0f, 0);
            part.Play();
            done = true;
        }

        if (bName == "47" && !done)
        {
            map.ile38 = true;
            transform.Translate(0, 1.0f, 0);
            part.Play();
            done = true;
        }

        if (bName == "48" && !done)
        {
            map.ile38 = true;
            transform.Translate(0, 1.0f, 0);
            part.Play();
            done = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            isPlayerIn = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerIn = false;
        }
    }

    private void TriggerTest()
    {
        if(isPlayerIn && Input.GetButtonDown("Action"))
        {
            Activate();
        }
    } 
}
