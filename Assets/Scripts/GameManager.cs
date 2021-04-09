using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public UserInput userInput;

    public GameObject panel;

    private void Awake()
    {
        instance = this;
        GameStop();
    }

    public void GameStart()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameStop()
    {
        Time.timeScale = 0;
    }
}
