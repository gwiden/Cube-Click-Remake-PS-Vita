using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Lose : MonoBehaviour
{
    [SerializeField] GameObject _fakeblockPrefab;
    [SerializeField] Vector3[] _positionsVec3;
    [SerializeField] Text _scoreText;
    [SerializeField] Button _replayButton;
    [SerializeField] Button _homeButton;

    private void Awake()
    {
        _replayButton.onClick.AddListener(delegate { Application.LoadLevel("play"); });
        _homeButton.onClick.AddListener(delegate { Application.LoadLevel("main"); });
        _scoreText.text = PlayerPrefs.GetInt("Score").ToString();
        for (int i = 0; i < _positionsVec3.Length; i++)
        {
            Instantiate(_fakeblockPrefab, _positionsVec3[i], Quaternion.identity);
        }
    }

}
