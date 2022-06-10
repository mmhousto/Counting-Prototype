using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public GameObject gameOverScreen;

    public TextMeshProUGUI hiScoreLabel;

    private int hiScore;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        hiScore = PlayerPrefs.GetInt("HiScore", 0);
        hiScoreLabel.text = $"HiScore: {hiScore}";
        gameOverScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        if (hiScore < Counter.Instance.Count)
        {
            hiScore = Counter.Instance.Count;
            PlayerPrefs.SetInt("HiScore", hiScore);
            hiScoreLabel.text = $"HiScore: {hiScore}";
        }
            
        gameOverScreen.SetActive(true);
    }
    
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
