using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public float moveSpeed = 5f; 

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * (moveSpeed * Time.deltaTime));
        }

   
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * (moveSpeed * Time.deltaTime));
        }
    }
}