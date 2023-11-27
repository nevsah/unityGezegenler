using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class merkurRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Transform gunes;
    public Transform merkur;


    void Update()
    {

        //merkur
        merkur.transform.Rotate(Vector3.up, 150 * Time.deltaTime);
        merkur.transform.RotateAround(gunes.position, Vector3.up, 150 * Time.deltaTime);

    }
}
