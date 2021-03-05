using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDownTest : MonoBehaviour
{
    public string anterior1;
    public string posterior1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(posterior1))
        {
            print("it works");
        }
    }
}
