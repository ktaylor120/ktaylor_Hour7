using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComTest : MonoBehaviour
{
    // Start is called before the first frame update
    Light lightComponent; //Variable that stores the light component.
    void Start()
    {
        lightComponent = GetComponent<Light> ();
        lightComponent.type = LightType.Directional;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
