using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{   
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    int score = 0;
    int highscore = 0;

    private void Awake(){
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore",0);
        scoreText.text = "Socre: " + score.ToString() + " POINTS";
        highScoreText.text = "High Score: " + highscore.ToString() + " POINTS";
    }

    public void AddPoint(){
        score += 1;
        scoreText.text = "Socre: " + score.ToString() + " POINTS";
        if(highscore < score){
            PlayerPrefs.SetInt("highscore",score);
        }
    }

    public int getScore(){
        return score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
