using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour{
    public void playGame()

{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    
}

}