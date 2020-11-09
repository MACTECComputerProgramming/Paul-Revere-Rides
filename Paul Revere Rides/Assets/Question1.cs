using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Question1 : MonoBehaviour{

   public void PlayGame  ()
    {
        SceneManager.UnloadSceneAsync("Question1");
    }
 
}
