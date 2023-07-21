using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text;
using UnityEngine.SceneManagement;

public class target : MonoBehaviour
{
    public  int Target = 5; 
    public static int level=1;
   
    public TextMeshProUGUI TargetUI;
    
    
    void Start()
    {
        
         
    }
    // Update is called once per frame
    void Update()
    {
        TargetUI.text = "TARGET : "+Target.ToString();
        
        if(UDPScript.count >= Target)
        {
            LoadGame();
            level+=1;
        }
   
    }

    public void LoadGame()
    {
         
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
          
    }
}
