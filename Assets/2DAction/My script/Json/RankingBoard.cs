using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class RankingBoard : MonoBehaviour
{
    private string dataPath;

    private void Awake()
    {
        dataPath = Application.dataPath + "/Resources/DataRanking.json";
    }
    RankingData LoadRanking(string dataPath)
    {
        StreamReader reader = new StreamReader(dataPath);
        string allData = reader.ReadToEnd();
        reader.Close();
        Debug.Log(allData);
        return JsonUtility.FromJson<RankingData>(allData);
    }

    private void OnEnable()
    {
        //RankingData _ld = LoadRanking(dataPath);
        /*string _ildstr = Resources.Load<TextAsset>("DataRanking").ToString();
        RankingData _ild = JsonUtility.FromJson<RankingData>(_ildstr);*/
        /*foreach(var time in _ld.time)
        {

        }*/

        //List<string> list = GetRankingTexts();
        //foreach(string str in list)
        //{
        //    Debug.Log(str);
        //}
    }

    public void OnClearGame()//これをクリアタイムが呼ばれるタイミングで呼ぶ、sceneにこれをつけたgameobjectをつける
    {
       /* List<string> list = GetRankingTexts();
        foreach (string str in list)
        {
            Debug.Log(str);
        }*/

    }
    
   /* public List<string> GetRankingTexts()
    {
        RankingData _ld = LoadRanking(dataPath);
        List<string> result = new List<string>();
        /*string _ildstr = Resources.Load<TextAsset>("DataRanking").ToString();
        RankingData _ild = JsonUtility.FromJson<RankingData>(_ildstr);*/
       /* foreach (var time in _ld.time)
        {
            result.Add(time.ToString());
        }
        result.Add("2");//clear time をいれる
        SaveRanking(_ld);
    }*/

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
