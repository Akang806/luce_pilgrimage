using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
   public TextMeshProUGUI pointsText;

   public void Setup(int score){
    gameObject.SetActive(true);
    pointsText.text = "Score: " + score.ToString() + " POINTS";
   }

   public void RestartButton(){
    SceneManager.LoadScene("GameScene2");
   }

   public void MainMenuButton(){
    SceneManager.LoadScene("Menu");
   }
}
