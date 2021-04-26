using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // lai stradāt ar ainam
public class StartButton : MonoBehaviour
{
    public void button()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //maiņa ainas uz 2
    }
    public void button2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); //maiņa ainas uz 1
    }
}
