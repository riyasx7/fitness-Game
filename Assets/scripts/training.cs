using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class training : MonoBehaviour{
    public void train()

{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    
}
 public void multi()

{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    
}
public void yoga()

{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    
}
}