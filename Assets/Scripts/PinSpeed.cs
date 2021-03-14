using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinSpeed : MonoBehaviour
{
    public Slider slider;
    public Text pinSpeedText;




    void Update()
    {
        pinSpeedText.text = slider.value.ToString();
        slider.onValueChanged.AddListener(delegate { ChangePinSpeed(); });        
        }

    public void ChangePinSpeed()
    {
        Pin.pinSpeed = slider.value;
    }
}
