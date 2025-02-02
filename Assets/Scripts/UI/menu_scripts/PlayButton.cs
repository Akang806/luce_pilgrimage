using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite defaultSprite;
    public Sprite clicked;
    
    void Start() {
        sr = gameObject.GetComponent<SpriteRenderer>();
    }
    void Update() {
        
    }
    public void OnMouseDown()
    {
        sr.sprite = clicked;
        SceneManager.LoadScene("GameScene2");
    }
    public void OnMouseUp()
    {
        sr.sprite = defaultSprite;
    }
}