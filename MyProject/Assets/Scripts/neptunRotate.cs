using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neptunRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Transform gunes;
    public Transform neptun;


    void Update()
    {

        //neptun
        neptun.transform.Rotate(Vector3.up, 1 * Time.deltaTime);
        neptun.transform.RotateAround(gunes.position, Vector3.up, 1 * Time.deltaTime);

    }
}
