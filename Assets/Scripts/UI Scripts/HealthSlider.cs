using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSlider : MonoBehaviour
{
    Slider healthBarSlider;
    // Start is called before the first frame update
    void Start()
    {
        healthBarSlider = gameObject.GetComponent<Slider>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
