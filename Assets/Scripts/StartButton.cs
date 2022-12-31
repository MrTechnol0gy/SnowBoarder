using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class StartButton : MonoBehaviour
{
    public int level;

    public void StartGame()
    {
        SceneManager.LoadScene(level);
    }
}
