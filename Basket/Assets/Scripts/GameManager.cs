using System;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public int life = 3;

    public GameObject[] lifeImage;

    public int appleCatchCount = 0;
    public int appleCount = 0;
    public int appleMissCount = 0;

    public int point = 0;

    public float time = 300f;

    public UnityAction OnGameEndEvent;
    

    private void OnEnable()
    {
        OnGameEndEvent += GameEnd;
    }

    private void Start()
    {
        Time.timeScale = 1;
    }

    private void Die()
    {
        life--;
        lifeImage[life].SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Die();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            appleCount++;
        }

        if (appleMissCount == 3)
        {
            lifeImage[2].SetActive(false);
        }

        if (appleMissCount == 6)
        {
            lifeImage[1].SetActive(false);
        }

        if (appleMissCount == 9)
        {
            lifeImage[0].SetActive(false);
        }

        if (time < 0)
        {
            return;
        }
        time -= Time.deltaTime;
        if (time < 0)
        {
            OnGameEndEvent();
        }
    }

    private void GameEnd()
    {
        Debug.Log("게임이 종료되었습니다.");
        Time.timeScale = 0;
    }

    private void Save()
    {
        PlayerPrefs.SetInt("HighScore", point);
    }

    private void Load()
    {
        if (PlayerPrefs.HasKey("HighScore")) ;
    }
}
