using UnityEngine;

public class InstructionsButton : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite defaultSprite;
    public Sprite hovered;
    public GameObject canvas; // Assign the Canvas GameObject in the Inspector
    public SpriteRenderer otherSR;
    public Sprite otherSprite;

    public SpriteRenderer titleSpriteRenderer;
    public Sprite titleSprite;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        canvas.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
    }
    void OnMouseDown()
    {
        canvas.SetActive(!canvas.activeSelf);
        sr.sprite = hovered;

        if (otherSR.sprite == otherSprite) {
            otherSR.sprite = null;
            titleSpriteRenderer.sprite = titleSprite;

        } else {
            otherSR.sprite = otherSprite;
            titleSpriteRenderer.sprite = null;
        }
    }

    void OnMouseUp() {
        sr.sprite = defaultSprite;
    }
}
