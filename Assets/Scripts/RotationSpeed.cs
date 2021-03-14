using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotationSpeed : MonoBehaviour
{
    public Slider slider;
    public Text rotationSpeedText;




    void Update()
    {
        rotationSpeedText.text = slider.value.ToString();
        slider.onValueChanged.AddListener(delegate { ChangeRotatorSpeed(); });
    }

    public void ChangeRotatorSpeed()
    {
       Rotator.rotatorSpeed = slider.value;
    }
}
