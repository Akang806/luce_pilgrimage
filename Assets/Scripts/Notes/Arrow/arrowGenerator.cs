using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowGenerator : MonoBehaviour
{    
    public RhythmParser rhythmParser;
    public GameObject loud_r_Hit;
    public GameObject soft_r_Hit;
    public GameObject loud_l_Hit;
    public GameObject soft_l_Hit;
    public GameObject tak1;
    public GameObject tak2;
    public GameObject tak3;
    public GameObject tak4;
    public GameObject tak5;
    public GameObject tak6;
    public GameObject loudDropper;
    public GameObject softDropper;

    public GameObject takDropper;

    public GameController gameController;


    // public SoundPlayer soundPlayer;
    // public float delay;
    
    public Transform leftSpawnPoint;   
    public Transform rightSpawnPoint;

    public List<string> leftDirections;
    public List<string> rightDirections;
    public List<double> BPM;



    private int index = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // delay = GameConstants.NOTE_DISTANCE / GameConstants.NOTE_SPEED;

        if (rhythmParser == null)
        {
            Debug.LogError("RhythmParser is not assigned!");
            return;
        }

        rhythmParser.ParseCSV();

        leftDirections = new List<string>(rhythmParser.GetLeftDirections()); 
        rightDirections = new List<string>(rhythmParser.GetRightDirections()); 
        BPM = new List<double>(rhythmParser.GetBPM()); 

        if (BPM.Count == 0)
        {
            Debug.LogError("No BPM values found. Check your CSV file.");
            return;
        }

        if (leftDirections.Count == 0)
        {
            Debug.LogError("No left direction values found. Check your CSV file.");
            return;
        }

        if (rightDirections.Count == 0)
        {
            Debug.LogError("No right direction values found. Check your CSV file.");
            return;
        }

        StartCoroutine(SpawnArrows());
    }

    IEnumerator SpawnArrows()
    {
      while (index < rhythmParser.BPM.Count){
        float beatInterval = (float) BPM[index];
        string leftDirection = leftDirections[index];
        string rightDirection = rightDirections[index];

        if (!string.IsNullOrWhiteSpace(leftDirection))
        {
            SpawnArrow(leftSpawnPoint, leftDirection, true);
        }

            // Spawn right arrow if needed
        if (!string.IsNullOrWhiteSpace(rightDirection))
        {
            SpawnArrow(rightSpawnPoint, rightDirection, false);
        }

        index++;
        yield return new WaitForSeconds(beatInterval);
      }

      if(index >= rhythmParser.BPM.Count){
         Debug.Log("Running game over");
         Invoke(nameof(GameOverCall), 4f);
      }
    }

     void SpawnArrow(Transform spawnPoint, string direction, bool left)
    {

        Quaternion rotation = Quaternion.identity;
        GameObject arrow;
        GameObject dropper;
        switch (direction) {
            case "L": 
                // Invoke(nameof(PlayBassSound), delay);
                if (left) {
                    arrow = Instantiate(loud_l_Hit, spawnPoint.position, rotation);
                } else {
                    arrow = Instantiate(loud_r_Hit, spawnPoint.position, rotation);
                }
                dropper = Instantiate(loudDropper, leftSpawnPoint.position, rotation);
                break;
            case "S": 
                // Invoke(nameof(PlayBassSound), delay);
                if (left) {
                    arrow = Instantiate(soft_l_Hit, spawnPoint.position, rotation);
                } else {
                    arrow = Instantiate(soft_r_Hit, spawnPoint.position, rotation);
                }
                dropper = Instantiate(softDropper, leftSpawnPoint.position, rotation);
                break;
            //up facing arrow
            case "t1":
                // Invoke(nameof(PlaySnareSound), delay);
                arrow = Instantiate(tak1, spawnPoint.position, rotation);
                dropper = Instantiate(takDropper, leftSpawnPoint.position, rotation);
                break;
            //right facing arrow
            case "t2":
                // Invoke(nameof(PlaySnareSound), delay);
                // soundPlayer.playSnare();
                arrow = Instantiate(tak2, spawnPoint.position, rotation);
                dropper = Instantiate(takDropper, leftSpawnPoint.position, rotation);
                break;
            //down facing arrow
            case "t3":
                // Invoke(nameof(PlaySnareSound), delay);
                // soundPlayer.playSnare();
                arrow = Instantiate(tak3, spawnPoint.position, rotation);
                dropper = Instantiate(takDropper, leftSpawnPoint.position, rotation);
                break;
            case "t4":
                // Invoke(nameof(PlaySnareSound), delay);
                // soundPlayer.playSnare();
                arrow = Instantiate(tak4, spawnPoint.position, rotation);
                dropper = Instantiate(takDropper, leftSpawnPoint.position, rotation);
                break;
            //left facing arrow
            case "t5":
                // Invoke(nameof(PlaySnareSound), delay);
                // soundPlayer.playSnare();
                arrow = Instantiate(tak5, spawnPoint.position, rotation);
                dropper = Instantiate(takDropper, leftSpawnPoint.position, rotation);
                break;
            //down facing arrow
            case "t6":
                // Invoke(nameof(PlaySnareSound), delay);
                // soundPlayer.playSnare();
                arrow = Instantiate(tak6, spawnPoint.position, rotation);
                dropper = Instantiate(takDropper, leftSpawnPoint.position, rotation);
                break;
            default:
                return;
        }
        
        Arrow arrowScript = arrow.GetComponent<Arrow>();

        if (arrowScript != null)
        {
            //NOTE: Change this for later
            arrowScript.hasStarted = true;
        }
    }


    void GameOverCall()
    {
        gameController.GameOver();
    }

    // void PlayBassSound()
    // {
    //     if (soundPlayer != null) soundPlayer.playBass();
    // }

    // void PlaySnareSound()
    // {
    //     if (soundPlayer != null) soundPlayer.playSnare();
    // }



    // Update is called once per frame
    void Update()
    {
        
    }
}
