using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Game : MonoBehaviour {

    [SerializeField] GameObject _blockPrefab;
    [SerializeField] Vector3[] _positionsVec3;
    GameObject[] blocks = new GameObject[16];
    [SerializeField] GameObject _timerPrefab;
    AudioSource _rightAudioSource;
    [SerializeField] Text _scoreText;
    int _scoreInt = 0;
    GameObject _timerObj;
    int Num;
    [SerializeField] Text screenNumber;

    private void Awake()
    {
        _scoreText.text = _scoreInt.ToString();
        _rightAudioSource = GetComponent<AudioSource>();
        Num = Random.Range(1, 16);
        screenNumber.text = Num.ToString();
        int n = 0;
        for (int i = 0; i < _positionsVec3.Length; i++)
        {
            n++;
            blocks[i] = Instantiate(_blockPrefab, _positionsVec3[i], Quaternion.identity) as GameObject;
            blocks[i].name = n.ToString();
        }
        _timerObj = Instantiate(_timerPrefab);
    }

    public void check(string str)
    {
        if (Equals(str, Num.ToString()))
        {
            rightChoice();
        }
        else
        {
            Lose();
        }
    }
    private void rightChoice()
    {
        _scoreInt++;
        _rightAudioSource.Play();
        _scoreText.text = _scoreInt.ToString();
        Num = Random.Range(1, 16);
        screenNumber.text = Num.ToString();
        Destroy(_timerObj.gameObject);
        _timerObj = Instantiate(_timerPrefab);
        
    }

    public void Lose()
    {
        PlayerPrefs.SetInt("Score", _scoreInt);

        if (PlayerPrefs.GetInt("MaxScore") < _scoreInt)
        {
            PlayerPrefs.SetInt("MaxScore", _scoreInt);
        }
        Application.LoadLevel("lose");
    }
}
