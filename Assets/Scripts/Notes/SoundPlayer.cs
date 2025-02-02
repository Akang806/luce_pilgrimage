using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    [SerializeField] public AudioSource src;
    public AudioClip bass,snare;

    public void playBass(){
         src.clip = bass;
         src.Play();
    }

    public void playSnare(){
        src.clip = snare;
        src.Play();

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
