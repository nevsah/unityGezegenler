using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    public Transform gunes;
    public Transform dunya;


    void Update()
    {

        //dunya
        dunya.transform.Rotate(Vector3.up, 40 * Time.deltaTime);
        dunya.transform.RotateAround(gunes.position, Vector3.up, 40 * Time.deltaTime);

    }
}
