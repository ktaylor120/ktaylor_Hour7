using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvenNumberOutput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 22; i < 102; i += 2)
            print(i);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
