using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private SpriteRenderer sr;
    public Sprite defaultImage;
    public Sprite pressedImage;
    public KeyCode loudKey;
    public KeyCode takOne;
    public KeyCode takTwo;
    public KeyCode takThree;

    void Start() {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = defaultImage;
    }

    void Update() {
        if(Input.GetKeyDown(takOne)) {
            sr.sprite = pressedImage;
        }
        if(Input.GetKeyUp(takOne)) {
            sr.sprite = defaultImage;
        }

        if(Input.GetKeyDown(takTwo)) {
            sr.sprite = pressedImage;
        }
        if(Input.GetKeyUp(takTwo)) {
            sr.sprite = defaultImage;
        }

        if(Input.GetKeyDown(takThree)) {
            sr.sprite = pressedImage;
        }
        if(Input.GetKeyUp(takThree)) {
            sr.sprite = defaultImage;
        }

        if(Input.GetKeyDown(loudKey)) {
            sr.sprite = pressedImage;
        }
        if(Input.GetKeyUp(loudKey)) {
            sr.sprite = defaultImage;
        }
    }
}
