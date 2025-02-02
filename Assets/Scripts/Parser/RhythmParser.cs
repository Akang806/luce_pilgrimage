using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "RhythmParser", menuName = "Scriptable Objects/RhythmParser")]
public class RhythmParser : ScriptableObject
{
    // 1. Create a field for the CSV file.
    [SerializeField] private TextAsset csvFile;

    public List<string> leftDirections = new List<string>();
    public List<string> rightDirections = new List<string>();
    public List<double> BPM = new List<double>();

    public void ParseCSV()
    {
        leftDirections.Clear();
        rightDirections.Clear();
        BPM.Clear();

        //Debug.Log($"left size = {leftDirections.Count} | values = {string.Join(", ", leftDirections)}");
        Debug.Log($"right size = {rightDirections.Count} | values = {string.Join(", ", rightDirections)}");
        Debug.Log($"BPM size = {BPM.Count} | values = {string.Join(", ", BPM)}");

        if (csvFile == null)
        {
            Debug.LogWarning("No CSV file assigned to RhythmParser ScriptableObject.");
            return;
        }

        // 3. Read CSV text from the assigned TextAsset.
        string csvText = csvFile.text;

        // 4. Here, parse the CSV. For example, using simple string splitting:
        string[] lines = csvText.Split('\n');

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            // Skip empty lines (especially the last one)
            if (string.IsNullOrWhiteSpace(line))
                continue;

            // Split each line by commas or another delimiter you use
            string[] entries = line.Split(',');

            Debug.Log($"entries size = {entries.Length} | values = {string.Join(", ", entries)}");

            leftDirections.Add(entries[0]);
            rightDirections.Add(entries[1]);

            double doubVal = double.Parse(entries[2]);

            BPM.Add(60.0/doubVal);

            // Do something with the entries...
            Debug.Log("Parsed line: " + line);
        }

        Debug.Log($"left size = {leftDirections.Count} | values = {string.Join(", ", leftDirections)}");
        Debug.Log($"right size = {rightDirections.Count} | values = {string.Join(", ", rightDirections)}");
        Debug.Log($"BPM size = {BPM.Count} | values = {string.Join(", ", BPM)}");
        
    }

    public List<string> GetLeftDirections()
    {
        return leftDirections;
    }

    public List<string> GetRightDirections()
    {
        return rightDirections;
    }

    public List<double> GetBPM()
    {
        return BPM;
    }
}
