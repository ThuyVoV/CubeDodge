using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRotation : MonoBehaviour
{
    public Transform teleportLocation;
    public GameObject player;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){

    }

	private void OnTriggerEnter(Collider collider) {

        //if (!Movement.canTele)
          //  return;

        Vector3 playPos = player.transform.position;
        Vector3 telPos = teleportLocation.transform.position;
        player.transform.position = new Vector3(telPos.x, telPos.y + playPos.y, telPos.z);
        
	}
}
