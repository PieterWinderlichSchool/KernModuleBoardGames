using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using UnityEngine.UI;

    public class ScoreManager : MonoBehaviour
    { 
        [SerializeField]  
    private Text _currentScoreText;
    [SerializeField]
    private Text _HighScoreText;
    private int _currentScore = 0;
    private bool _HighscoreBreached = false;

    private int _HighScore = 0;
    
    
    void Start()
    {   
        
        if(PlayerPrefs.GetInt("Highscore" )!= 0)
        {
            _HighScore = PlayerPrefs.GetInt("Highscore");
        }
        UpdateScore(0);
    }


    public void UpdateScore(int scoreAddition)
    {
        
        _currentScore += scoreAddition;
        if (_HighScore < _currentScore)
        {
            
            PlayerPrefs.SetInt("Highscore" , _currentScore);
            _HighScore = _currentScore;
            _HighscoreBreached = true;
        }
        _currentScoreText.text = "Souls amount:" + "\n" + _currentScore /10;
        _HighScoreText.text = "Current soul Highscore:" + "\n" + _HighScore/10;
    }
}
