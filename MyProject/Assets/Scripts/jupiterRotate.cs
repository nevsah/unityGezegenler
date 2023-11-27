using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jupiterRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Transform gunes;
    public Transform jupiter;


    void Update()
    {

        //jupiter
        jupiter.transform.Rotate(Vector3.up, 10 * Time.deltaTime);
        jupiter.transform.RotateAround(gunes.position, Vector3.up, 10 * Time.deltaTime);

    }
}
