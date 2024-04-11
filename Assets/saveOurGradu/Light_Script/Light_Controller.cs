using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Light_Controller : MonoBehaviour
{
    public Light pointLight;
    public float color;
    public Slider colorSlider;

    public float intensity;
    public Slider intensitySlider;

    public float range;
    public Slider rangeSlider;

    public float distance;
    public Slider distanceSlider;

    // Start is called before the first frame update
    void Start()
    {
        intensitySlider.onValueChanged.AddListener(ChangeIntensity);
        rangeSlider.onValueChanged.AddListener(ChangeRange);
        distanceSlider.onValueChanged.AddListener(ChangeDistance);
    }

    void ChangeIntensity(float newIntensity)
    {
        pointLight.intensity = newIntensity;
    }

    void ChangeRange(float newRange)
    {
        pointLight.range = newRange;
    }
    void ChangeDistance(float newDistance)
    {
        pointLight.range = newDistance;
    }
}
