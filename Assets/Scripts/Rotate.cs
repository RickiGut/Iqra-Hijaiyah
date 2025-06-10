using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 10;

    private string sumbu;
    private bool putar;

    // Update is called once per frame
    void Update()
    {
        if (putar)
        {
            if (sumbu.ToUpper().Equals ("X"))
            {
                transform .Rotate(Vector3.up * speed);
            }

            if (sumbu.ToUpper().Equals("Y"))
            {
                transform .Rotate(Vector3.up * -speed);
            }
                
        }
    }

    public void RotateCube(string Sumbu)
    {
        this.sumbu = Sumbu;
        putar = true;
    }

    public void StopRotation()
    {
        putar = false;
    }
}
