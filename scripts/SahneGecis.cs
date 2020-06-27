using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneGecis : MonoBehaviour
{
    public void SonrakiSahneyeGec()
    {
        int suankisahne = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(suankisahne + 1);
    }
    public void OyunaGit()
    {
        SceneManager.LoadScene(1);
    }
    public void Cikis()
    {
        Application.Quit();
    }
}
