using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator animPlay;
    public Animator animQuit;

    public void PlayGame()
    {
        animPlay.SetBool("pressed", true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        StartCoroutine(FinishCut());
    }

    public void QuitGame()
    {
        animQuit.SetBool("pressed", true);
        Debug.Log("Quit!");
        Application.Quit();
        StartCoroutine(FinishCut());
    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(0.1f);
        animQuit.SetBool("pressed", false);
        animPlay.SetBool("pressed", false);
    }
}
