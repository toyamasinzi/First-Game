using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 360) * Time.deltaTime);//360�x��]
    }
   /* void OnCollisionEnter2D(Collision2D collision)
    {
        //�Փ˂��������player1�܂���player2�^�O���t���Ă�Ƃ�
        if (collision.gameObject.tag == "Player1" || collision.gameObject.tag == "Player2")
        {
            //0.01�ŏ�����
            Destroy(collision.gameObject, 0.01f);
        }
    }*/
}
