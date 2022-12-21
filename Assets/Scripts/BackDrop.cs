using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackDrop : MonoBehaviour
{

    public float scrollSpeed;

    private Renderer backgroundRenderer;
    private Vector2 savedOffset;

    // Start is called before the first frame update
    void Start()
    {
        backgroundRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Repeat(Time.time * scrollSpeed, 1);
        Vector2 offset = new Vector2(x, 0);
        backgroundRenderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
