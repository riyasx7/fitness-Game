using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text;
public class text : MonoBehaviour
{
     public int ans;
    public TextMeshProUGUI ansUI;
    
    public Animator mAnimator;
    public int ans1=0;
    

  

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(UDPScript.count != 0)
        { 
             ans=UDPScript.count;
             ansUI.text = ans.ToString();

        }
        if(ans1 != UDPScript.count)
        {
              mAnimator.SetTrigger("start");
              ans1 = UDPScript.count;
        }
        
    }
}
