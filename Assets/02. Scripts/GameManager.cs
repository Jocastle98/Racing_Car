using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gasHP; 
    private int currentGas; 
    public GameObject gameOverUI; 

    void Start()
    {
        currentGas = int.Parse(gasHP.text);
        
        GasDecrease();
    }

    private async void GasDecrease()
    {
        while (true)
        {
            await Task.Delay(1000);
            
            currentGas -= 5;
            
            gasHP.text = currentGas.ToString();
            
            if (currentGas <= 0)
            {
                OnGameOver();
                Time.timeScale = 0; 
                break;
            }
        }
    }

    public void AddGas(int amount)
    {
        currentGas += amount;
        gasHP.text = currentGas.ToString();
    }

    public void DecreaseGas(int amount)
    {
        currentGas -= amount;
        gasHP.text = currentGas.ToString();
    }
    public void OnGameOver()
    {
        gameOverUI.SetActive(true);
    }
}