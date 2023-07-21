using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class spawnplayer : MonoBehaviourPunCallbacks
{
    public GameObject playerPrefab;
    
    
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float minZ;
    public float maxZ;
    public float gap = 2;

    void Start()
    {
        
       
        Vector3 randomPostion = new Vector3(Random.Range(minX + gap,maxX + gap), Random.Range(minY,maxY), Random.Range(minZ,maxZ));
        PhotonNetwork.Instantiate(playerPrefab.name, randomPostion, Quaternion.Euler(0,-180,0));
       

    }

   
}
