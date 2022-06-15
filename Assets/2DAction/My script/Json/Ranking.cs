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
        dataPath = Application.dataPath + "/DataRanking.json";
    }

    void Start()
    {
        RankingData data = new RankingData();
        float[] _sd = { 1, 2, 3 };
        data.time = _sd;
        SaveRanking(data);
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
