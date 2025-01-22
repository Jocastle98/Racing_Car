using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GasTrigger : MonoBehaviour
{
    public GameManager gameManager; 
    public int gasIncrease = 10;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.AddGas(gasIncrease);
            gameObject.SetActive(false);
        }
    }
}
