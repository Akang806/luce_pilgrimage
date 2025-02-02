using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class LuceAnimator : MonoBehaviour
{
    public List<Image> frames; // Drag your 4 images here in the Inspector
    public float frameDelay = 0.2f; // Adjust to control animation speed
    private int currentFrame = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(AnimateGIF());
    }

    IEnumerator AnimateGIF(){
        while (true){

            foreach (var img in frames)
            {
                img.enabled = false;
            }

            if(currentFrame >= frames.Count-1){
                frames[frames.Count - 1].enabled = true;
                currentFrame = currentFrame - 1;
                yield return new WaitForSeconds(frameDelay);

            }else if(currentFrame == frames.Count - 2){
                frames[currentFrame].enabled = true;
                currentFrame = 0;
            }else{
                frames[currentFrame].enabled = true;
                currentFrame = (currentFrame + 1);
            }

            yield return new WaitForSeconds(frameDelay);

        }
    }

    public void createFall(){
        currentFrame = frames.Count + 2;
    }
}
