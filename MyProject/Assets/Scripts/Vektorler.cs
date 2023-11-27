using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vektorler : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 pozisyon;
    // Start is called before the first frame update
    void Start()
    {
        pozisyon = new Vector3(0,0,0);

    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(pozisyon);

    }
}
