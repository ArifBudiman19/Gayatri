using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugInput : MonoBehaviour {

    void ControllerCheck()
    {
        /**
        float ltaxis = Input.GetAxis("LeftTrigger");
        float rtaxis = Input.GetAxis("RightTrigger");
        float dhaxis = Input.GetAxis("XboxDpadHorizontal");
        float dvaxis = Input.GetAxis("XboxDpadVertical");
        */

        float ltaxis = Input.GetAxis("LT");
        float rtaxis = Input.GetAxis("RT");
        float dhaxis = Input.GetAxis("DPADH");
        float dvaxis = Input.GetAxis("DPADV");
        float lhorizontal = Input.GetAxis("Horizontal");
        float lvertical = Input.GetAxis("Vertical");
        float rhTurn = Input.GetAxis("HorizontalTurn");
        float rvTurn = Input.GetAxis("VerticalTurn");

        bool xbox_a = Input.GetButton("A");
        bool xbox_b = Input.GetButton("B");
        bool xbox_x = Input.GetButton("X");
        bool xbox_y = Input.GetButton("Y");
        bool xbox_lb = Input.GetButton("LB");
        bool xbox_rb = Input.GetButton("RB");
        bool xbox_ls = Input.GetButton("LSB");
        bool xbox_rs = Input.GetButton("RSB");
        bool xbox_view = Input.GetButton("Back");
        bool xbox_menu = Input.GetButton("Start");

        if (rhTurn != 0)
        {
            Debug.Log("Right Stick Horizontal : " + rhTurn);
        }

        if (rvTurn != 0)
        {
            Debug.Log("Right Stick Vertical : " + rvTurn);
        }

        if(lhorizontal != 0)
        {
            Debug.Log("Left Stick Horizontal : " + lhorizontal);
        }

        if (lvertical != 0)
        {
            Debug.Log("Left Stick Vertical : " + lvertical);
        }

        if (ltaxis != 0)
        {
            Debug.Log("Left Trigger : " + ltaxis);
        }

        if (rtaxis != 0)
        {
            Debug.Log("Right Trigger : " + rtaxis);
        }

        if(dhaxis != 0)
        {
            Debug.Log("DPAD - Horizontal : " + dhaxis);
        }

        if (dvaxis != 0)
        {
            Debug.Log("DPAD - Vertical : " + dvaxis);
        }

        if (xbox_a)
        {
            Debug.Log("A");
        }

        if (xbox_b)
        {
            Debug.Log("B");
        }

        if (xbox_x)
        {
            Debug.Log("X");
        }

        if (xbox_y)
        {
            Debug.Log("Y");
        }

        if (xbox_lb)
        {
            Debug.Log("Left Bumper");
        }

        if (xbox_rb)
        {
            Debug.Log("Right Bumper");
        }

        if (xbox_view)
        {
            Debug.Log("Back");
        }

        if (xbox_menu)
        {
            Debug.Log("Start");
        }

        if (xbox_ls)
        {
            Debug.Log("Left Stick Button");
        }

        if (xbox_rs)
        {
            Debug.Log("Right Stick Button");
        }
    
    }

    // Update is called once per frame
    void Update () {
        ControllerCheck();
    }
}
