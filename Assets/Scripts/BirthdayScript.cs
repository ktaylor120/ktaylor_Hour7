using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirthdayScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int count = 0;
        while (count <= 12)
        {
            Debug.Log(count);
            count++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
