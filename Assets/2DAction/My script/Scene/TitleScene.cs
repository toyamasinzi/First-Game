using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour
{
    [SerializeField] string _Scene = "Result";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(_Scene);
    }
}