using UnityEngine;

public class LoopMap : MonoBehaviour
{
    private Material materialInstance;
    public float offsetSpeed = 0.5f;

    void Start()
    {
        SpriteRenderer sp = GetComponent<SpriteRenderer>();
        if (sp != null)
        {
            materialInstance = Instantiate(sp.material);
            sp.material = materialInstance;
            Debug.Log("Material instance created successfully.");
        }
        else
        {
            Debug.LogError("SpriteRenderer not found on the GameObject.");
        }
    }

    void Update()
    {
        if (materialInstance != null)
        {
            float offsetVal = offsetSpeed * Time.deltaTime;
            Vector2 newOffset = materialInstance.mainTextureOffset + new Vector2(0f, offsetVal);
            materialInstance.SetTextureOffset("_MainTex", newOffset);

            // Debugging the offset value
            Debug.Log($"New Offset: {newOffset}");
        }
        else
        {
            Debug.LogError("Material instance is null.");
        }
    }
}