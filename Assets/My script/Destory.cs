using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Õ“Ë‚µ‚½‘Šè‚Éplayerƒ^ƒO‚ª•t‚¢‚Ä‚é‚Æ‚«
        if (collision.gameObject.tag == "Player1" || collision.gameObject.tag == "Player2")
        {
            //0.2•b‚ÅÁ‚¦‚é
            Destroy(collision.gameObject, 0.01f);
        }
    }

}
