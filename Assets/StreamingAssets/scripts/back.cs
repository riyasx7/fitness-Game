using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour
{
   public void rev()
   {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
   }
   public void rev2()
   {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
   }
  
   public void rev3()
   {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
   }
   public void rev4()
   {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
   }
   public void rev5()
   {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
   }
   

}
