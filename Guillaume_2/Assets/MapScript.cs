using UnityEngine;
using System.Collections;

public class MapScript : MonoBehaviour {
    public bool ile11 = false;
    public bool ile12 = false;
    public bool ile13 = false;
    public bool ile14 = false;
    public bool ile15 = false;
    public bool ile16 = false;
    public bool ile21 = false;
    public bool ile22 = false;
    public bool ile23 = false;
    public bool ile24 = false;
    public bool ile25 = false;
    public bool ile31 = false;
    public bool ile32 = false;
    public bool ile33 = false;
    public bool ile34 = false;
    public bool ile35 = false;
    public bool ile36 = false;
    public bool ile37 = false;
    public bool ile38 = false;
    public bool ile41 = false;
    public bool ile42 = false;
    public bool ile43 = false;
    public bool ile44 = false;
    public bool ile45 = false;
    public bool ile46 = false;
    public bool ile47 = false;
    public bool ile48 = false;
    public Transform pont1;
    public Transform pont2;
    public Transform pont3;
    public Transform pont4;
    public Transform pont5;
    public float moveSpeed;


    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        Ile1();
        Ile2();
        Ile3();
        Ile4();

	}

    void Ile1 ()
    {
        if (ile11 && ile12 && ile13 && ile14 && ile15 && ile16)
        {
            if(pont1.position.y < -225f)
            {
                pont1.Translate(0, moveSpeed * Time.deltaTime, 0);
            }
        }
    }

    void Ile2()
    {
        if (ile21 && ile22 && ile23 && ile24 && ile25)
        {
            if(pont2.position.y < 9.5f)
            {
                pont2.position += new Vector3(0, moveSpeed * Time.deltaTime, 0);
            }
        }
    }

    void Ile3()
    {
        if (ile31 && ile32 && ile33 && ile34 && ile35 && ile36 && ile37 && ile38)
        {
            if (pont3.position.y < 10f)
            {
                pont3.position += new Vector3(0, moveSpeed * Time.deltaTime, 0);
            }
        }
    }

    void Ile4()
    {
        if (ile41 && ile42 && ile43 && ile44 && ile45 && ile46 && ile47 && ile48)
        {
            if(pont4.position.y < 10.4f)
            {
                pont4.position += new Vector3(0, moveSpeed * Time.deltaTime, 0);
            }
            if(pont5.position.y < 377.5f)
            {
                pont5.position += new Vector3(0, moveSpeed * Time.deltaTime, 0);
            }
        }
    }
}
