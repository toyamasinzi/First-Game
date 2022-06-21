using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class Timer : MonoBehaviour
{
    public GameObject trm;
    private bool stop = false;
    [SerializeField] string Scene = "Result";

    public string nowTime;

    public float _CountTime;
    string datapath;
    private string _Save;

    public void Awake()
    {
        datapath = Application.dataPath + "/TimeRanking";
    }
    void Start()
    {
        gameObject.GetComponent<Text>();
        trm = GameObject.Find("_timer");
        _CountTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (stop == false)
        {
            _CountTime += Time.deltaTime;
            trm.GetComponent<Text>().text = _CountTime.ToString("F1");
            //trm.GetComponent<Text>().text = Time.time.ToString("F1");
            //json _c =  _CountTime.ToString();
            // nowTime = _testCountTime.ToString("F1");

        }

    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.tag == "Goal")
        {
            stop = true;
            SaveData savedata = new SaveData(_CountTime.ToString("F1"));
            string json = JsonUtility.ToJson(savedata);
            PlayerPrefs.SetString("SaveData", _CountTime.ToString("F1"));
            //Debug.Log($"JSON: {json}");
            
            

            //Debug.Log("json");
            SceneManager.LoadScene(Scene);
            //Timer _time = gameObject.AddComponent<Timer>();
            /*PlayerPrefs.SetString("time", nowTime);
            PlayerPrefs.Save();
            Debug.Log(PlayerPrefs.GetString("time") + "Save");*/

            /*Json _c = new Json();//ÉGÉâÅ[Ç…Ç»ÇÈ
            Save(_c);*/
        }

    }
   /* public void Save(Json _c)
    {
string jsonstr = JsonUtility.ToJson(_c);
        StreamWriter writer = new StreamWriter(datapath, false);
        writer.WriteLine(jsonstr);
        writer.Flush();
        writer.Close();
    }*/
}

