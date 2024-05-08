using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AlignNorth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Input.compass.enabled = true;
        Input.location.Start();
    }

    // Update is called once per frame
    void Update()
    {
        // constantly adjust the rotation of the topocentric origin so it is aligned with north
        transform.rotation = Quaternion.Euler(0, -Input.compass.trueHeading, 0);
    }
}
