using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderText : MonoBehaviour
{

    private Slider slider;
    private Text Stext;
   
    private void Awake()
    {
        slider = GetComponentInParent<Slider>();
        Stext = GetComponent<Text>();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        Updatetext(slider.value);
        slider.onValueChanged.AddListener(Updatetext);
        
    }

    // Update is called once per frame
    void Updatetext(float val)
    {
        Stext.text = slider.value.ToString();

    }
}
