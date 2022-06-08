using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 360) * Time.deltaTime);//360度回転
    }
   /* void OnCollisionEnter2D(Collision2D collision)
    {
        //衝突した相手にplayer1またはplayer2タグが付いてるとき
        if (collision.gameObject.tag == "Player1" || collision.gameObject.tag == "Player2")
        {
            //0.01で消える
            Destroy(collision.gameObject, 0.01f);
        }
    }*/
}
