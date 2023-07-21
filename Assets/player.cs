using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;


public class player : MonoBehaviourPunCallbacks
{ //Fetch the Animator
  public Animator anim;
  public int ans=0;
  void update()
  {
    if(ans==1)
    {
        anim.SetTrigger("multi");
    }
  }


} 
    
