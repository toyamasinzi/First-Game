using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] float tr = 0f;
    GameObject trm;
    //private Text te;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>();
        trm = GameObject.Find("_timer");
    }

    // Update is called once per frame
    void Update()
    {
        //tr += Time.deltaTime;
        trm.GetComponent<Text>().text = Time.time.ToString("F1");
    }
}
