using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using Unity.Mathematics;

public class Score : MonoBehaviour
{
    public static Score instance;

    public float score = 0;
    public float scoreToWin = 100;

    public Text scoreText;
    public Text comboText;

    public int combo = 0;
    public float scoreCombo;

    public GameObject scorePrefab;


    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        comboText = GameObject.Find("ComboText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        comboText.text = combo.ToString();

        if (score > scoreToWin)
        {
            Invoke("loadScene", 3f);
        }
    }

    public void AddScore(float ScoreAdd, Transform pos)
    {
        if (combo == 0 || combo == 1)
        {
            scoreCombo = ScoreAdd;
            score += scoreCombo;
            instantiateScorePre(pos, scoreCombo);
            return;
        }
        scoreCombo = ScoreAdd * combo * 0.5f;
        score += scoreCombo;
        instantiateScorePre(pos, scoreCombo);

    }

    void loadScene()
    {
        SceneManager.LoadScene(2);
    }

    void instantiateScorePre(Transform pos, float scorecombo)
    {
        GameObject go = Instantiate(scorePrefab, pos.position, quaternion.identity, transform);
        go.GetComponent<TextMeshProUGUI>().text = scoreCombo.ToString();
        Debug.Log(go);
        Destroy(go, 0.6f);
    }
}
