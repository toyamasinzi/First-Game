using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] string Scene = "Game";
    void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(Scene);
    }
}
