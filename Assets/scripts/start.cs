using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour{
    public void playGame()

{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    
}
public void yoga()

{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 8);
    
}
public void log()

{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +9);
    
}
    public void home()

    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
    public void bac()

    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }


}