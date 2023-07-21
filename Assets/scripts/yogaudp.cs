using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

public class yogaudp : MonoBehaviour
{
    
    Thread receiveThread;
    UdpClient client; 
    public int port =1234;
    public bool startRecieving = true;
    public bool printToConsole = false;
    public string data = null;
    
   
    
    
    
    
    
   
    


    public void Start()
    {
       
        receiveThread = new Thread(
            new ThreadStart(Receivedata));
        receiveThread.IsBackground = true;
        receiveThread.Start();
       
        
    }
  
    private void Receivedata()
    {

        client = new UdpClient(port);
        while (startRecieving)
        {

            try
            {
                IPEndPoint anyIP = new IPEndPoint(IPAddress.Any, 0);
                byte[] dataByte = client.Receive(ref anyIP);
                data = Encoding.UTF8.GetString(dataByte);

                if (printToConsole){ print(data);  }
                
            }
            catch (Exception err)
            {
                print(err.ToString());
            }
          
        }

    }
    



    // receive thread

   
   
      
}
