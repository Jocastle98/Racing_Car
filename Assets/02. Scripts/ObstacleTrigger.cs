using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleTrigger : MonoBehaviour
{
    public GameManager gameManager; 
    public int gasDecrease = 3;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.DecreaseGas(gasDecrease);
            gameObject.SetActive(false);
        }
    }
}
