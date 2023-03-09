using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirthdayScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int count = 0;
        do
        {
            count++;
            Debug.Log(count);
        }
        while (count < 1);
        Debug.Log("It's my birthday month!");

        count = 0;
        do
        {
            count++;
            Debug.Log(count);
        }
        while (count < 20);
        Debug.Log("It's my Birthday!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
