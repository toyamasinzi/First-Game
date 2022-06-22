using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

[System.Serializable]
public class RankingData
{
    public float[] time;
}

public class Ranking : MonoBehaviour
{
    private string dataPath;

    private void Awake()
    {
        dataPath = Application.dataPath + "/Resources/DataRanking.json";
    }

    void Start()
    {
       // RankingBoard data = new RankingBoard();
       /* List<string> _sd = data.GetRankingTexts();
        //data.time = _sd;
        RankingData ranking = new RankingData();
        for (var i = 0; i < _sd.Count; i++) 
        {
            ranking.time[i] = float.Parse(_sd[i]);
        }
            SaveRanking(ranking);*/

    }
    public void SaveRanking(RankingData data)
    {
        string jsonData = JsonUtility.ToJson(data);
        StreamWriter writer = new StreamWriter(dataPath, false);
        writer.WriteLine(jsonData);
        writer.Flush();
        writer.Close();
        Debug.Log(dataPath);
    }
}
