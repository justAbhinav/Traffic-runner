using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class menu_ki_mummy : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    // Update is called once per frame
    void Update()
    {
    }
    
    public void clickSound()
    {
        source.PlayOneShot(clip);
    }

    public void GameStart() { 
        Thread.Sleep(100);
        SceneManager.LoadScene(1);
    }

    public void GameEnd()
    {
        Thread.Sleep(100);
        Application.Quit();
    }

    public void GameOver()
    {   
        Thread.Sleep(100);
        SceneManager.LoadScene(0);
    }

}
