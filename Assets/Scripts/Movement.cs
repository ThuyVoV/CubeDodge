using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float horForce;
    public float jumpForce;
    private bool canJump;
    private bool mRight;
    private bool mLeft;

    public Rigidbody rBody;

    void Start() {
        
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.W)) {
            canJump = true;
        }
        if (Input.GetKey(KeyCode.A)) {
            mLeft = true;
        }
        if (Input.GetKey(KeyCode.D)) {
            mRight = true;
        }
    }

    void FixedUpdate() {
        if (canJump) {
            canJump = false;
            rBody.AddForce(0, jumpForce, 0);
        }
		if (mLeft) {
            mLeft = false;
            //rBody.AddForce(-horForce * Time.deltaTime, 0, 0);
            transform.position += -transform.forward * Time.deltaTime * horForce;
		}
		if (mRight) {
            mRight = false;
            //rBody.AddForce(horForce * Time.deltaTime, 0, 0);
            transform.position += transform.forward * Time.deltaTime * horForce;
        }
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("hitt teleortt");
        this.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
