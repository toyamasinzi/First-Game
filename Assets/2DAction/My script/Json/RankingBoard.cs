using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class RankingBoard : MonoBehaviour
{
    private string dataPath;

    private void Awake()
    {
        dataPath = Application.dataPath + "/DataRanking.json";
    }
    RankingData LoadRanking(string dataPath)
    {
        StringReader reader = new StringReader(dataPath);
        string allData = reader.ReadToEnd();
        reader.Close();
        Debug.Log(allData);
        return JsonUtility.FromJson<RankingData>(allData);
    }

    private void OnEnable()
    {
        RankingData _ld = LoadRanking(dataPath);
        /*string _ildstr = Resources.Load<TextAsset>("DataRanking").ToString();
        RankingData _ild = JsonUtility.FromJson<RankingData>(_ildstr);*/
        foreach(var time in _ld.time)
        {
            Debug.Log(time);
        }
    }

}
