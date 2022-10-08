using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Input : MonoBehaviour
{
    private TouchScreenKeyboard keyboard;  
    public TMP_Text nameTextOnScreen; 
    public TMP_Text randomTextOnScreen; 
    // public TMP_InputField inputField; 
    private int counter = 0;
    // private TMP_InputField nameInput;

    void Start () {
    //    nameInput = inputField.GetComponent<TMP_InputField>();
    } 

    public void OpenMobileKeyboard()
    {   
        //if mobile browser 
        keyboard = TouchScreenKeyboard.Open(randomTextOnScreen.text, TouchScreenKeyboardType.Default); 
    }
  
    public void ShowUserInput() { 
        // nameInput.text = keyboard.text; 
        randomTextOnScreen.text = keyboard.text;
        Debug.Log(randomTextOnScreen.text);
        Debug.Log(keyboard.text);
    }

    public void ShowCounterForDebugging() { 
                counter += 1;
                randomTextOnScreen.text = counter.ToString(); 
    }

    void Update()
    {
                //if mobile browser 
            if (keyboard != null && !keyboard.active) {
                ShowUserInput();
                ShowCounterForDebugging();
            } 
    }  
}
