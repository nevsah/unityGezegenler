using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marsRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Transform gunes;
    public Transform mars;


    void Update()
    {

        //mars
        mars.transform.Rotate(Vector3.up, 20 * Time.deltaTime);
        mars.transform.RotateAround(gunes.position, Vector3.up, 20 * Time.deltaTime);

    }
}
