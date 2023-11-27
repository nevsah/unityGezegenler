using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uranusRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Transform gunes;
    public Transform uranus;


    void Update()
    {

        //uranus
        uranus.transform.Rotate(Vector3.up, 3 * Time.deltaTime);
        uranus.transform.RotateAround(gunes.position, Vector3.up, 3 * Time.deltaTime);

    }
}
