using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ChangeCheckpoint : MonoBehaviour
{
    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            PlayerMovementBM.CP = gameObject;
            SceneManager.LoadScene("Question1", LoadSceneMode.Additive);
            Time.timeScale = 0f;
        }

    }


}
