using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float horForce;
    public float jumpForce;
    private bool canJump;
    private bool mRight;
    private bool mLeft;
    public static bool canTele = true;
    private float cooldown = 2;
    public float timer=0;

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

        if (timer > 0)
            timer -= Time.deltaTime;

        if (timer <= 0 && canTele == false) {
            canTele = true;
            timer = cooldown;
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
        //Debug.Log("hitt teleortt");
        if (!canTele)
            return;
        Debug.Log(other.gameObject.name);
		if (other.gameObject.name == "testteleport")
            this.transform.rotation = Quaternion.Euler(0, 0, 0);
        if (other.gameObject.name == "teleport2")
            this.transform.rotation = Quaternion.Euler(0, 90, 0);

        canTele = false;
    }
}
