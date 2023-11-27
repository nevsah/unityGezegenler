using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunesRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Transform gunes;
    public float donmeHizi;

    void Update()
    {
        gunes.transform.Rotate(Vector3.up, 10 * Time.deltaTime);

    }
}
