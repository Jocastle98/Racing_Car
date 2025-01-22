using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEvent : MonoBehaviour
{
    public Button startButton;

    public GameObject startUI;
    //public Button endButton;

    void Start()
    {
        Time.timeScale = 0;
        startButton.onClick.AddListener(OnStart);
    }

    public void OnStart()
    {
        Time.timeScale = 1;
        startUI.SetActive(false);
        Debug.Log("OnStart");
    }
}
