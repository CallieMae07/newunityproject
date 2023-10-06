
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrol : MonoBehaviour
{
    // create a public reference to the player - we will assign this using the unity player
    public GameObject player;

    void Update()
    {
        //change our position relative to the players position
        transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);

    }
}