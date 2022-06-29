using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swich4 : MonoBehaviour
{   
    //定義する
    [SerializeField] Animator _Moves;　
    [SerializeField] string _animStateName = "Move";

    private void OnTriggerEnter2D(Collider2D collision) //コライダーがトリガーだったら反応する
    {
        if (collision.gameObject.tag == "Player1" || collision.transform.tag == "Player2")//プレイヤー１またはプレイヤー２
        {
            _Moves.Play(_animStateName);//アニメーションを再生する
          
        }
    }
}
