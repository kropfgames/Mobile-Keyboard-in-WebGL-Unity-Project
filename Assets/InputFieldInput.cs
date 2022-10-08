using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class InputFieldInput : MonoBehaviour
{
    private TouchScreenKeyboard keyboard;  
    public TMP_InputField NameInputField;   
    private string name;

    void Start () { 
    } 

    public void OpenMobileKeyboard()  {   
        //if mobile browser 
        keyboard = TouchScreenKeyboard.Open(NameInputField.text, TouchScreenKeyboardType.Default); 
    }  

    void Update()
    {
                //if mobile browser 
            if (keyboard != null && keyboard.active) {
                 name = keyboard.text; 
            } else if (keyboard != null && !keyboard.active && name != null) {
                NameInputField.text = name; 
            }
    }  
}
