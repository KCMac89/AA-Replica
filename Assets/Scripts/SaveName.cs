using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveName : MonoBehaviour
{

    public InputField nameField;


    public void SavePlayerName()
    {
        PlayerPrefs.SetString("name", nameField.text);
    }
}
