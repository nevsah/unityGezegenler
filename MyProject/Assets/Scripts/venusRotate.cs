using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class venusRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Transform gunes;
    public Transform venus;

    void Update()
    {

        //venus
        venus.transform.Rotate(Vector3.up, 50 * Time.deltaTime);
        venus.transform.RotateAround(gunes.position, Vector3.up, -50 * Time.deltaTime);

    }
}
