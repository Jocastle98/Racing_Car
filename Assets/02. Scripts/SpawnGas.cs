using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGas : MonoBehaviour
{
    public GameObject gas;
    public float gasSpeed = 2f;

    void Update()
    {
        gas.transform.position -= new Vector3(0f, gasSpeed * Time.deltaTime, 0f);
    }
}
