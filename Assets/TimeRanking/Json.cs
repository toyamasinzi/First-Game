using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Json : MonoBehaviour
{
    [SerializeField] GameObject tim;
    private void Start()
    {
       string savadata = PlayerPrefs.GetString("SaveData");

       string trm = PlayerPrefs.GetString("SaveData");//���[�h
    
        /*Ranking1 rank = new Ranking1(trm.Split(','));
        PlayerPrefs.SetString("Save", rank.ToString());
        string _r = PlayerPrefs.GetString("Save");*/
        float _tim = float.Parse(trm);
       // float _rn = float.Parse(_r);//�G���[�����񂪐������`���ł͂���܂���ł����B

       /* if (_tim < _rn)
        {*/
           // Debug.Log("sava");
            tim.GetComponent<Text>().text = trm;
        //}
    }
}