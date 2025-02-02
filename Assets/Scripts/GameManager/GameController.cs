using UnityEngine;

public class GameController : MonoBehaviour
{
   public GameOverScript GameOverScreen;

   public void GameOver(){
    GameOverScreen.Setup(ScoreManager.instance.getScore());
   }

}
