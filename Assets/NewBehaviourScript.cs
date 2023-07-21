using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text;

public class NewBehaviourScript : MonoBehaviour
{
    public float fillQuantity;
    public Slider slider;
    public int increaser = 1;
    public TextMeshProUGUI level;
    private  bool lev = false;
    
     public void Start()
     {
        if(lev == false)
        {
            StartCoroutine(FillSlider());
        }
     }
     public IEnumerator FillSlider()
     {
       if(lev == false&&target.level == 2)
        {
         lev = true;
         yield return new WaitForSeconds(1);
         slider.value += fillQuantity;
         increaser+=1;
         level.text = increaser.ToString();
         StartCoroutine(FillSlider());
         
        }
       
     }
}
