﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    public GameObject targetObject;
    private float targetAngle = 0;
    const float rotationAmount = 5.0000000f;
    //public float rDistance = 1.0000000f;
    //public float rSpeed = 1.0f;

    // Update is called once per frame
    void Update() {

        // Trigger functions if Rotate is requested
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            targetAngle -= 90.0000000f;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow)) {
            targetAngle += 90.0000000f;
        }

        if (targetAngle != 0) {
            Rotate();
        }

        Debug.Log(targetAngle);
    }

    protected void Rotate() {

        //float step = rSpeed * Time.deltaTime;
        //float orbitCircumfrance = 2F * rDistance * Mathf.PI;
        //float distanceDegrees = (rSpeed / orbitCircumfrance) * 360;
        //float distanceRadians = (rSpeed / orbitCircumfrance) * 2 * Mathf.PI;

        if (targetAngle > 0) {
            transform.RotateAround(targetObject.transform.position, Vector3.up, -rotationAmount);
            targetAngle -= rotationAmount;
        }
        else if (targetAngle < 0) {
            transform.RotateAround(targetObject.transform.position, Vector3.up, rotationAmount);
            targetAngle += rotationAmount;
        }

    }
}
