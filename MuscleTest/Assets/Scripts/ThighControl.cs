using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThighControl : MonoBehaviour
{
    public SpringJoint anteriorLeftMuscle;
    public SpringJoint posteriorLeftMuscle;
    public bool posteriorLeftBool;
    public bool anteriorLeftBool;
    public string anteriorLeftKey;
    public string posteriorLeftKey;
    public SpringJoint anteriorRightMuscle;
    public SpringJoint posteriorRightMuscle;
    public bool posteriorRightBool;
    public bool anteriorRightBool;
    public string anteriorRightKey;
    public string posteriorRightKey;
    public float muscleForce = 50.0f;

    // Start is called before the first frame update
    void Start()
    {

        posteriorLeftBool = false;
        anteriorLeftBool = false;
        posteriorRightBool = false;
        anteriorRightBool = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(anteriorLeftKey))//anteriorBool == true)
        {
            anteriorLeftMuscle.spring = muscleForce;
            //posteriorBool = false;
        }
        else
        {
            anteriorLeftMuscle.spring = 10.0f;
        }

        if (Input.GetKey(posteriorLeftKey))//posteriorBool == true)
        {
            posteriorLeftMuscle.spring = muscleForce;
            //anteriorBool = false;
        }
        else
        {
            posteriorLeftMuscle.spring = 10.0f;
        }
        if (Input.GetKey(anteriorRightKey))//anteriorBool == true)
        {
            anteriorRightMuscle.spring = muscleForce;
            //posteriorBool = false;
        }
        else
        {
            anteriorRightMuscle.spring = 10.0f;
        }

        if (Input.GetKey(posteriorRightKey))//posteriorBool == true)
        {
            posteriorRightMuscle.spring = muscleForce;
            //anteriorBool = false;
        }
        else
        {
            posteriorRightMuscle.spring = 10.0f;
        }
    }
}
