using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGas : MonoBehaviour
{
    public GameObject[] gass; 
    public float gasSpeed = 2f; 
    
    public enum GAS_TYPE
    {
        LEFT,
        RIGHT,
        MIDDLE,
        NONE
    }
    public GAS_TYPE gasType;

    void Start()
    {
        randomGas();
    }

    void Update()
    {
        for (int i = 0; i < gass.Length; i++)
        {
            gass[i].transform.position -= new Vector3(0f, gasSpeed * Time.deltaTime, 0f);
            if (gass[i].transform.position.y <= -6)
            {
                gass[i].transform.position = new Vector3(gass[i].transform.position.x, 6f, gass[i].transform.position.z );
                randomGas();
            }
        }
    }

    public void randomGas()
    {
        foreach (var gas in gass)
        {
            gas.SetActive(false);
        }

        int ranInt = Random.Range(0, 4);
        gasType = (GAS_TYPE)ranInt;
        
        switch (gasType)
        {
            case GAS_TYPE.LEFT:
                gass[0].SetActive(true); 
                break;

            case GAS_TYPE.RIGHT:
                gass[2].SetActive(true); 
                break;

            case GAS_TYPE.MIDDLE:
                gass[1].SetActive(true); 
                break;

            case GAS_TYPE.NONE:
                gass[0].SetActive(false);
                gass[1].SetActive(false);
                gass[2].SetActive(false);
                break;
        }
    }
}