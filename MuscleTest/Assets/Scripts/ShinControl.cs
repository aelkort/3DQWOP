using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShinControl : MonoBehaviour
{
    public SpringJoint[] muscles;
    public SpringJoint anteriorMuscle;
    public SpringJoint posteriorMuscle;
    public bool posteriorBool;
    public bool anteriorBool;
    public string anteriorKey;
    public string posteriorKey;
    public float muscleForce = 50.0f;

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
        if (Input.GetKey(anteriorKey))//anteriorBool == true)
        {
            anteriorMuscle.spring = muscleForce;
            //posteriorBool = false;
        }
        else
        {
            anteriorMuscle.spring = 10.0f;
        }

        if (Input.GetKey(posteriorKey))//posteriorBool == true)
        {
            posteriorMuscle.spring = muscleForce;
            //anteriorBool = false;
        }
        else
        {
            posteriorMuscle.spring = 10.0f;
        }
    }
}