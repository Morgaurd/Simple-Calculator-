using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CalculatorOperations : MonoBehaviour
{
    public Text inputField;

    int answer;
    int[] numb = new int[2];
    int i = 0;

    string mathSymbol;
    string stringVal;

    bool answerPanel = false;
    public void ButtonPushed()
    {
        if (answerPanel == true)
        {
            stringVal = "";
            answerPanel = false;
        }

        Debug.Log(EventSystem.current.currentSelectedGameObject.name);

        string buttonVal = EventSystem.current.currentSelectedGameObject.name;
        stringVal += buttonVal;

        int val;
        if (int.TryParse(buttonVal, out val))
        {
            if (i > 1) i = 0;
            numb[i] = val;
            i++;
        }
        else
        {
            switch(buttonVal)
            {
                case "+":
                    mathSymbol = buttonVal;
                    break;
                case "*":
                    mathSymbol = buttonVal;
                    break;
                case "-":
                    mathSymbol = buttonVal;
                    break;
                case "/":
                    mathSymbol = buttonVal;
                    break;
                case "C":
                    stringVal = "";
                    break;
                case "=":
                    switch (mathSymbol)
                    {
                        case "+":
                            answer = numb[0] + numb[1];
                            break;
                        case "*":
                            answer = numb[0] * numb[1];
                            break;
                        case "-":
                            answer = numb[0] - numb[1];
                            break;
                        case "/":
                            answer = numb[0] / numb[1];
                            break;

                    }
                    answerPanel = true;
                    stringVal = answer.ToString();
                    numb = new int[2];
                    break;

            }
        }
        
        
        inputField.text = stringVal;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
