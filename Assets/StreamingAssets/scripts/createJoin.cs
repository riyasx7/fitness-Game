using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text;
using Photon.Pun;

public class createJoin : MonoBehaviourPunCallbacks
{
    public TextMeshProUGUI createInput;
    public TextMeshProUGUI joinInput;

    public void CreateRoom()
    {
         PhotonNetwork.CreateRoom(createInput.text);
    }
     public void JoinRoom()
    {
         PhotonNetwork.JoinRoom(joinInput.text);
    }
     public override void OnJoinedRoom()
    {
      PhotonNetwork.LoadLevel("Game");
    }

  
    
}
