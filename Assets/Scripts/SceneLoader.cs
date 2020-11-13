using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }
    public static void LoadWin()
    {
        SceneManager.LoadScene("Win Scene");
    }
    public static void LoadLose()
    {
        SceneManager.LoadScene("Lose Scene");
    }
}
