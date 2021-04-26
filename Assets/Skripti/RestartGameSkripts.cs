using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement; //lai stradāt ar ainam

public class RestartGameSkripts : MonoBehaviour
{
    public void restart()
    {
            SceneManager.LoadScene("PilsetasAina"); //load PilsetasAina (restartēt)
    }
}
