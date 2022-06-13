using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Json : MonoBehaviour
{
    [SerializeField] GameObject tim;
    string savadata = PlayerPrefs.GetString("SaveData");

    string _r = PlayerPrefs.GetString("Save");
    private void Start()
    {
       string trm = PlayerPrefs.GetString("SaveData");//ƒ[ƒh
        Ranking1 rank = new Ranking1(trm.Split(','));
        PlayerPrefs.SetString("Save", trm.ToString());
         float _tim = float.Parse(trm);

        float _rn = float.Parse(_r);

         if (_tim > _rn)
        {
            tim.GetComponent<Text>().text = trm;
        } 
    }
}