using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destory : MonoBehaviour
{
    [SerializeField] string Scene = "GameOver";
    void OnCollisionEnter2D(Collision2D collision)
    {
        //�Փ˂��������player1�܂���player2�^�O���t���Ă�Ƃ�
        if (collision.gameObject.tag == "Player1" || collision.gameObject.tag == "Player2")
        {
            //Destroy(collision.gameObject, 0.01f);
            SceneManager.LoadScene(Scene);
        }
    }

}
