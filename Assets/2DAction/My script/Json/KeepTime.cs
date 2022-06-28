using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepTime : MonoBehaviour
{
    [SerializeField] GameObject _kptm;
    float _nowTime;
    [SerializeField] InputField inputField;

    void Start()
    { 
        _nowTime = Timer.getTime();
            print(_nowTime);

        gameObject.GetComponent<Text>();
    }
    private void Update()
    {
        _kptm.GetComponent<Text>().text = _nowTime.ToString("F1");
    }
}