using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score instance;

    public float score = 0;
    public float scoreToWin = 100;

    public Text scoreText;


    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();

        if (score > scoreToWin)
        {
            Invoke("loadScene", 3f);
        }
    }

    public void AddScore(float ScoreAdd)
    {
        score += ScoreAdd;
    }

    void loadScene()
    {
        SceneManager.LoadScene(2);
    }
}
