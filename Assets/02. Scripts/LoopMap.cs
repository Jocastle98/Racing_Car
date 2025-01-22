using UnityEngine;

public class LoopMap : MonoBehaviour
{
    private Material materialInstance;
    public float offsetSpeed = 0.5f;

    void Start()
    {
        SpriteRenderer sp = GetComponent<SpriteRenderer>();
        materialInstance = Instantiate(sp.material);
        sp.material = materialInstance;
    }

    void Update()
    {
        float offsetVal = offsetSpeed * Time.deltaTime;
        Vector2 newOffset = materialInstance.mainTextureOffset + new Vector2(0f, offsetVal);
        materialInstance.SetTextureOffset("_MainTex", newOffset);
        
    }
}