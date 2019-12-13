using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] sprites;
    public float framesPerSecond;
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<Renderer>() as SpriteRenderer; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
            index = index % sprites.Length;
            spriteRenderer.sprite = sprites[index];
        }
    }
}
