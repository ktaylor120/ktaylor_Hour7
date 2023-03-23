using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    GameObject blueBerryGO;
    // Start is called before the first frame update
    void Start()
    {
        blueBerryGO = GameObject.Find("blueberry");
        blueBerryGO.transform.Translate(new Vector3(0, 1, 4));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
