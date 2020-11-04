using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CorrectAns : MonoBehaviour
{
    public bool correct;
    public void button()
    {
        if (correct == true) {
            Debug.Log("Test");
            SceneManager.UnloadSceneAsync("Question1");
                Time.timeScale = 1f;
                } else { SceneManager.LoadScene("GameOver"); Debug.Log("Test2");
 }
    }
<<<<<<< Updated upstream

=======
    
>>>>>>> Stashed changes
   
}
