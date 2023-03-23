using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //put together a loop that outputs 9 - 0
        int count = 0;

        //Debug.Log("This is my count " + count);
        do
        {
            count--;
            Debug.Log("This is my count " + count);
        }
        while (count > 0);

        //put together a loop that outputs 9 - 0
        count = 0;

        //Debug.Log("This is my count " + count);
        while (count > 0)
        {
            count--;
            Debug.Log("This is my count " + count);
        }

        for (int i = 10; i > 0; i--)
        {
            if (i > 3)
            {
                Debug.Log("Lucky number " + i);
            }
            else
            {
                Debug.Log("This is my count " + i);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
