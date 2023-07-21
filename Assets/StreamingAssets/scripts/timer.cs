using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    private int SecondsLeft = 5;
    public TextMeshProUGUI SecondsLeftUI;
    public bool TakingAway = false;
    public UDPScript udpreceive;
    private int count1=1;
    
    void Start()
    {
        SecondsLeftUI.text = "00:0"+SecondsLeft.ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(TakingAway==false && SecondsLeft>0)
        {
            StartCoroutine(TimerTake());
        }
    }
    IEnumerator TimerTake()
    {
        TakingAway = true;
        yield return new WaitForSeconds(1);
        SecondsLeft-=1;
        SecondsLeftUI.text = "00:0"+SecondsLeft.ToString(); 
        if(UDPScript.count == count1 )
        {
            SecondsLeft = 5;
            SecondsLeftUI.text = "00:0"+SecondsLeft.ToString(); 
            count1+=1;
            TakingAway = false;
        }
        if(SecondsLeft==0)
        {
            load();
        }
        else
        {
          TakingAway = false;
        }
        
        
    }
    public void load()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

    }
  
}
