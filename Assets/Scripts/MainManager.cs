using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    int counter = 0;
    private static bool _created = false;
    TargetScript _targetScript;
    float increaseTargetSpeed;

    private void Awake()
    {
        if (!_created)
        {
            DontDestroyOnLoad(this.gameObject);
            _created = true;
        }
    }

    private void Start()
    {
        _targetScript = FindObjectOfType<TargetScript>();
    }

    public int Rounds
    {
        get
        {
            return PlayerPrefs.GetInt("Round", 1);
        }
        set
        {
            PlayerPrefs.SetInt("Round", value);
        }

    } 

    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
        Rounds++;
        //Rounds=1;
        Debug.Log(Rounds);
    }

    public void SaveCounter()
    {
        PlayerPrefs.SetInt("savedcounter", counter);
    }

}
