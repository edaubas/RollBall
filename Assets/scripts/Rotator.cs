using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
    
    public float delay;
    float timecounter = 0;
    float radio = 6;

    void Start()
    {
        timecounter = delay;
    }
    // Update is called once per frame
    void Update () {
        transform.Rotate(new Vector3(30, 30, 30) * Time.deltaTime);

        timecounter += Time.deltaTime;
        //float y = 0.1f / Time.deltaTime;
        float y = 2;
        float x = Mathf.Cos(timecounter) * radio;
        float z = Mathf.Sin(timecounter) * radio;
        transform.position = new Vector3(x, y, z);
    }
}
