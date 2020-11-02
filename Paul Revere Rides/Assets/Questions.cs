using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questions : MonoBehaviour
{
    public Text question, ans1, ans2, ans3, ans4;
    
    void Start()
    {
          int rnd = Random.Range(1, 8);


        switch (rnd)
        {
            case 1:
                question.text = "What part of the government is here because of Paul Revere?";
                ans1.text = "CIA";
                ans2.text = "FBI";
                ans3.text = "NGA";
                ans4.text = "MI6";
                ans1.GetComponentInParent<CorrectAns>().correct = true;
                break;
           
            case 2:
                question.text = "How did Paul Revere alert everyone when he saw the British on their way?";
                ans1.text = "He rode through yelling “The British are coming!”";
                ans2.text = "Used a bird";
                ans3.text = "Sent a telegram";
                ans4.text = "Ran into the taverns and told them";
                ans4.GetComponentInParent<CorrectAns>().correct = true;
                break;
           
            case 3:
                question.text = "What did Paul Revere not do for a job after the american revolution?";
                ans1.text = "Foundry";
                ans2.text = "Copper Mill";
                ans3.text = "President";
                ans4.text = "Hardware store";

                ans3.GetComponentInParent<CorrectAns>().correct = true;
                break;
           
            case 4:
                question.text = "Paul Revere the only rider that night?";
                ans1.text = "Yes";
                ans2.text = "No";
                ans2.GetComponentInParent<CorrectAns>().correct = true;
                break;

            case 5:
                question.text = "What was Paul Revere’s real last name?";
                ans1.text = "Revere";
                ans2.text = "Rivoire";
                ans3.text = "Middleton";
                ans4.text = "Rivera";
                ans1.GetComponentInParent<CorrectAns>().correct = true;
                break;

            case 6:
                question.text = "What year was Paul Revere born?";
                ans1.text = "1735";
                ans2.text = "1736";
                ans3.text = "1819";
                ans4.text = "1727";
                ans1.GetComponentInParent<CorrectAns>().correct = true;
                break;


            case 7:
                question.text = "What year did Paul Revere die";
                ans1.text = "1792";
                ans2.text = "1884";
                ans3.text = "1756";
                ans4.text = "1818";
                ans4.GetComponentInParent<CorrectAns>().correct = true;
                break;
        }
    }
}
