using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowName : MonoBehaviour


{
    public Text nameText;
  
    void Start()
    {
        nameText.text = PlayerPrefs.GetString("name");

    }

 
}
