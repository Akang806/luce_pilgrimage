using UnityEngine;

public class parser_test : MonoBehaviour
{
     [SerializeField] private RhythmParser rhythmParser;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Calls ParseCSV method on the ScriptableObject at runtime.
        if (rhythmParser != null)
        {
            rhythmParser.ParseCSV();
        }else{
            Debug.LogWarning("RhythmParser reference is missing.");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
