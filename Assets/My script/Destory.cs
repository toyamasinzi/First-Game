using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        //�Փ˂��������player�^�O���t���Ă�Ƃ�
        if (collision.gameObject.tag == "Player1" || collision.gameObject.tag == "Player2")
        {
            //0.2�b�ŏ�����
            Destroy(collision.gameObject, 0.01f);
        }
    }

}
