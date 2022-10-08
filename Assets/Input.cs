using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Input : MonoBehaviour
{
    private TouchScreenKeyboard keyboard;  
    public TMP_Text nameTextOnScreen; 
    public TMP_Text randomTextOnScreen;  
    private int counter = 0; 
    private string name;

    void Start () {
        name = "NoName333"; 
    } 

    public void OpenMobileKeyboard()
    {   
        //if mobile browser 
        keyboard = TouchScreenKeyboard.Open(randomTextOnScreen.text, TouchScreenKeyboardType.Default); 
    } 
    public void ShowCounterForDebugging() { 
                counter += 1;
                randomTextOnScreen.text = counter.ToString(); 
    }

    void Update()
    {
                //if mobile browser 
            if (keyboard != null && keyboard.active) {
                 name = keyboard.text;
                ShowCounterForDebugging();
            } else if (keyboard != null && !keyboard.active) {
                nameTextOnScreen.text = name; 
            }
    }  
}
