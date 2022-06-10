using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Lives : MonoBehaviour
{
    public static Lives Instance { get; private set; }

    private TextMeshProUGUI lifeText;

    public static int lives = 0;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        lifeText = GetComponent<TextMeshProUGUI>();
        lives = 5;
    }

    private void Update()
    {
        if(lives <= 0)
        {
            GameManager.Instance.GameOver();
            lives = 0;
        }
    }

    public void LoseLife()
    {
        if(lives > 0)
        {
            lives -= 1;
            lifeText.text = "Lives: " + lives;
        }
        
    }
}
