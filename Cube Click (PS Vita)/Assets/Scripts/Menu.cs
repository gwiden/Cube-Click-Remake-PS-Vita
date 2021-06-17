using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    [SerializeField] Button _startButton;
    [SerializeField] Button _howButton;
    [SerializeField] Text _maxScoreText;

    private void Awake()
    {
        _maxScoreText.text = PlayerPrefs.GetInt("MaxScore").ToString();
        _startButton.onClick.AddListener(delegate { Application.LoadLevel("play"); });
        _howButton.onClick.AddListener(delegate { Application.LoadLevel("how"); });
    }
}
