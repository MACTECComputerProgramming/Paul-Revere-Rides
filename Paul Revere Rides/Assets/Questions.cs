using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questions : MonoBehaviour
{
    public Text question, ans1, ans2, ans3, ans4;
    
    void Start()
    {
        //  int rnd = Random.Range(1, 8);
        int rnd = Random.Range(1, 1);

        switch (rnd)
        {
            case 1:
                question.text = "Question";
                ans1.text = "correect";
                ans2.text = "wrong";
                ans3.text = "w";
                ans4.text = "w";
                ans1.GetComponentInParent<CorrectAns>().correct = true;
                break;
                
        }
    }
}
