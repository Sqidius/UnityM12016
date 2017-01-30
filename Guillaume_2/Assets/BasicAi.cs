using UnityEngine;
using System.Collections;

public class BasicAi : MonoBehaviour
{
    private Vector3 pPos;
    private Vector3 dep;
    private bool isIn = false;
    void Start()
    {
        pPos = target.position;
    }
    public Transform target;

    void Update()
    {
        updatePlayer();

    }

    void updatePlayer()
    {
        if(pPos != target.position && !isIn)
        {
            transform.LookAt(target);
            transform.Translate(Vector3.forward * 5 * Time.deltaTime);
            pPos = target.position;
        }
    }

    public void stop()
    {
        isIn = true;
    }

    public void go()
    {
        isIn = false;
    }

}