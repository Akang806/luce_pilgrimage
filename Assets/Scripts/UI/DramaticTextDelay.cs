using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DramaticTextDelay : MonoBehaviour
{
    public GameObject previousDelay;
    void Start(){
        StartCoroutine(FadeTextToFullAlpha(1f, GetComponent<TextMesh>()));
        if (previousDelay != null) {
            previousDelay.GetComponent<DramaticTextDelay>().FadeTextToZeroAlpha(1f, previousDelay.GetComponent<TextMesh>());
        }
    }
// can ignore the update, it's just to make the coroutines get called for example
    void Update()
    {
        
    }



    public IEnumerator FadeTextToFullAlpha(float t, TextMesh i)
    {
        i.color = new Color(0,0,0,0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(0,0,0, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
    }

    public IEnumerator FadeTextToZeroAlpha(float t, TextMesh i)
    {
        i.color = new Color(0,0,0,1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(0,0,0, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }
}