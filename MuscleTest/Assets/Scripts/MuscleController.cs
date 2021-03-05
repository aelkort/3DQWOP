using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuscleController : MonoBehaviour
{
    public SpringJoint[] muscles;
    public SpringJoint anteriorMuscle; 
    public SpringJoint posteriorMuscle;
    public bool posteriorBool;
    public bool anteriorBool;

    // Start is called before the first frame update
    void Start()
    {
        muscles = GetComponents<SpringJoint>();
        anteriorMuscle = muscles[0];
        posteriorMuscle = muscles[1];
        posteriorBool = false;
        anteriorBool = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))//anteriorBool == true)
        {
            anteriorMuscle.spring = 50.0f;
            //posteriorBool = false;
        }
        else
        {
            anteriorMuscle.spring = 10.0f;
        }

        if (Input.GetMouseButton(1))//posteriorBool == true)
        {
            posteriorMuscle.spring = 50.0f;
            //anteriorBool = false;
        }
        else
        {
            posteriorMuscle.spring = 10.0f;
        }
    }
}
