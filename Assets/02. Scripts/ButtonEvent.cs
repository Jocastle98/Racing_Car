using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonEvent : MonoBehaviour
{
    public Button startButton;

    public GameObject startUI;
    public GameObject endUI;
    public Button endButton;

    void Start()
    {
        Time.timeScale = 0;
        startButton.onClick.AddListener(OnStart);
        endButton.onClick.AddListener(OnGameOVer);
    }

    public void OnGameOVer()
    {
        Time.timeScale = 1;
        endUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void OnStart()
    {
        Time.timeScale = 1;
        startUI.SetActive(false);
    }
}