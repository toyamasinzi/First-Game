using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Jsonを保存したり読み込んだりするのを確認するスクリプト
/// </summary>
public class JsonTest : MonoBehaviour
{
    RankingData _rankingData;
    void Start()
    {
        JsonModel.CreateJson(new RankingData(new float[] {10f, 5f},//保存
            new string[] {"プレイヤーA", "プレイヤーB" }),
            Application.persistentDataPath + "/RankingData.json");

        RankingData _data = JsonModel.LoadJson<RankingData>(Application.persistentDataPath + "/RankingData.json");//ロード
        
        for(int i = 0; i < _data.Names.Length; i++)//ランキング
        {
            print($"{_data.Names[i]}は{_data.Times[i]}秒にゴールした");
        }
    }
}
