using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saturnRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Transform gunes;
    public Transform saturn;


    void Update()
    {

        //saturn
        saturn.transform.Rotate(Vector3.up, 6 * Time.deltaTime);
        saturn.transform.RotateAround(gunes.position, Vector3.up, 6 * Time.deltaTime);

    }
}
