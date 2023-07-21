using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text;
public class textyoga : MonoBehaviour
{
      public string ans;
      public TextMeshProUGUI ansUI;
      public yogaudp yoga;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ans = yoga.data;
        ansUI.text = ans.ToString();
    }
}
