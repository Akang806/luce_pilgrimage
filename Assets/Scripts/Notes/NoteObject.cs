using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;
    public KeyCode keyToPress;
    public KeyCode negativeKey1;
    public KeyCode negativeKey2;
    public KeyCode negativeKey3;

    public bool success;

    private LuceAnimator luceAnimator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Find the Luce_GIF GameObject and get its LuceAnimator component
        GameObject luceGIF = GameObject.Find("Luce_GIF");
        if (luceGIF != null)
        {
            luceAnimator = luceGIF.GetComponent<LuceAnimator>();
        }
        else
        {
            Debug.LogError("Luce_GIF GameObject not found in the scene!");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(negativeKey1) || Input.GetKeyDown(negativeKey2) || Input.GetKeyDown(negativeKey3) || Input.GetKeyDown(keyToPress)) {
            if (canBePressed) {
                if (success && Input.GetKeyDown(keyToPress)) {
                    ScoreManager.instance.AddPoint();
                }else if(!success){
                    luceAnimator.createFall();
                }
                gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "pressThreshold") {
            canBePressed = true;
        }
        if (other.tag == "Activator") {
            success = true;
        }
        if (other.tag == "Deactivator") {
            luceAnimator.createFall();
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.tag == "Activator") {
            success = false;
        }
    }
}
