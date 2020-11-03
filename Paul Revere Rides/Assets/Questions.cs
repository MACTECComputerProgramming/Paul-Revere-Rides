using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questions : MonoBehaviour
{
    public Text question, ans1, ans2, ans3, ans4;
    
    void Start()
    {
          int rnd = Random.Range(1, 13);


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
                ans3.text = " ";
                ans4.text = " ";
                ans2.GetComponentInParent<CorrectAns>().correct = true;
                break;

            case 5:
                question.text = "What was Paul Revere’s real last name?";
                ans1.text = "Revere";
                ans2.text = "Rivoire";
                ans3.text = "Middleton";
                ans4.text = "Rivera";
                ans2.GetComponentInParent<CorrectAns>().correct = true;
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

            case 8:
                question.text = "How many kids did Paul Revere have";
                ans1.text = "20";
                ans2.text = "3";
                ans3.text = "16";
                ans4.text = "9";
                ans3.GetComponentInParent<CorrectAns>().correct = true;
                break;

            case 9:
                question.text = "Who told Paul Revere that the British were coming";
                ans1.text = "Dr. Joseph Warren";
                ans2.text = "Abraham Lincoln";
                ans3.text = "King Geroge";
                ans4.text = "Alexander Hamilton";
                ans1.GetComponentInParent<CorrectAns>().correct = true;
                break;

            case 10:
                question.text = "Where did Paul Revere ride ";
                ans1.text = "Concord";
                ans2.text = "Boston";
                ans3.text = "Lexington";
                ans4.text = "Salem";
                ans3.GetComponentInParent<CorrectAns>().correct = true;
                break;

            case 11:
                question.text = "What is the name of the poem about Paul Revere";
                ans1.text = "The british are coming";
                ans2.text = "Midnight Ride";
                ans3.text = "Paul Revere's ride";
                ans4.text = "Paul Revere's Midnight Ride";
                ans3.GetComponentInParent<CorrectAns>().correct = true;
                break;

            case 12:
                question.text = "Who wrote the poem about Paul Revere";
                ans1.text = "Ernest Hemingway";
                ans2.text = "Henry WadsWorth Longfellow";
                ans3.text = "William Shakesperare";
                ans4.text = "Edgar Allan Poe";
                ans2.GetComponentInParent<CorrectAns>().correct = true;
                break;
        }
    }
}
