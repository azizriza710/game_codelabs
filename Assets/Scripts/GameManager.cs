using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOver;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text scoreText2;

    private float _time = 0f;
    public static GameManager _instance;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        _instance = this;
    }

    private void Update()
    {
        _time += Time.deltaTime;
        scoreText.text = "Score : " + Mathf.Round(_time).ToString();
        scoreText2.text = "Score : " + Mathf.Round(_time).ToString();
    }

    public void ShowGameOver()
    {
        Time.timeScale = 0f;
        gameOver.SetActive(true);
    }

    public void BtnRetry_OnClick()
    {
        Time.timeScale = 1f;
        gameOver.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
