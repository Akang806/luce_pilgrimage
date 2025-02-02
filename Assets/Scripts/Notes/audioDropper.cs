using UnityEngine;

public class AudioDropper : MonoBehaviour
{
    public bool isTak;
    public bool isLoud;
    public bool isSoft;
    public SoundPlayer soundPlayer;
    public float constantRate;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        constantRate = 2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0f, constantRate * Time.deltaTime, 0f);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Strummer") {
            if (isLoud) {
                if (soundPlayer != null) soundPlayer.playBass();
            } else if (isSoft) {
                if (soundPlayer != null) soundPlayer.playBass();
            } else if (isTak) {
                if (soundPlayer != null) soundPlayer.playSnare();
            } else {}
        }
    }
}
