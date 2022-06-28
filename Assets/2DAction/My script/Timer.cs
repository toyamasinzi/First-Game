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

    public static float _CountTime;
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
            SceneManager.LoadScene(Scene);
        }
    }
         public static float getTime()
    {

        return _CountTime;
    }
}


