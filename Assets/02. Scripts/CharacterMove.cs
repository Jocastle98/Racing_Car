using UnityEngine;
using UnityEngine.UI;

public class CharacterMove : MonoBehaviour
{
    public Button leftBtn;  
    public Button rightBtn; 
    public float moveSpeed = 5f; 

    private bool isMovingLeft = false; 
    private bool isMovingRight = false; 

    void Start()
    {
        leftBtn.onClick.AddListener(() => StartMovingLeft());
        rightBtn.onClick.AddListener(() => StartMovingRight());
    }

    void Update()
    {
        if (isMovingLeft)
        {
            transform.Translate(Vector3.left * (moveSpeed * Time.deltaTime));
        }
        
        if (isMovingRight)
        {
            transform.Translate(Vector3.right * (moveSpeed * Time.deltaTime));
        }
    }

    void StartMovingLeft()
    {
        isMovingLeft = true;
        isMovingRight = false;
        Invoke("StopMove", 1f);
    }

    void StartMovingRight()
    {
        isMovingLeft = false;
        isMovingRight = true;
        Invoke("StopMove", 1f);
    }

    void StopMove()
    {
        isMovingLeft = false;
        isMovingRight = false;
    }
}