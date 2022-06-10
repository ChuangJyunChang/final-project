using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFlow : MonoBehaviour
{
    public enum gameState
    {
        menu,
        inGame,
        conclusion
    }
    public static gameState gameNowState = gameState.menu;
    // Start is called before the first frame update

    void Awake()
    {
        gameNowState = gameState.menu;
    }

    public static void gameStateToInGame()
    {
        gameNowState = gameState.inGame;
        SceneManager.LoadScene(1);
    }

    public static void gameStateToConclusion()
    {
        gameNowState = gameState.conclusion;
    }
}
