using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class How : MonoBehaviour
{
    [SerializeField] GameObject _fakeblockPrefab;
    [SerializeField] Vector3[] _positionsVec3;
    [SerializeField] Button _closeButton;

    private void Awake()
    {
        _closeButton.onClick.AddListener(delegate { Application.LoadLevel("main"); });
        for (int i = 0; i < _positionsVec3.Length; i++)
        {
            Instantiate(_fakeblockPrefab, _positionsVec3[i], Quaternion.identity);
        }
    }

}
