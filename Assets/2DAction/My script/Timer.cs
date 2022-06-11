using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public GameObject trm;
    private bool stop = false;
    [SerializeField] string Scene = "Result";

    public string nowTime;

    private float _testCountTime;

    string time;
    //private Text te;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>();
        trm = GameObject.Find("_timer");
        _testCountTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(stop == false)
        {
            _testCountTime += Time.deltaTime;
            //trm.GetComponent<Text>().text = Time.time.ToString("F1");
            trm.GetComponent<Text>().text = _testCountTime.ToString("F1");
            nowTime = _testCountTime.ToString("F1");
        }
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(gameObject.tag =="Goal")
        {
            stop = true;
            PlayerPrefs.SetString("time", nowTime);
            PlayerPrefs.Save();
            Debug.Log(PlayerPrefs.GetString("time") + "Save");
            SceneManager.LoadScene(Scene);
        }

    }
}
