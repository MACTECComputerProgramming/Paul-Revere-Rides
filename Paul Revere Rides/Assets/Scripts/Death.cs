using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public Transform checkpoint;
    GameObject player;
    PlayerMovement PP;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            player.transform.position = PlayerMovement.CP.transform.position;
            player.transform.rotation = PlayerMovement.CP.transform.rotation;


        }
    }
}
