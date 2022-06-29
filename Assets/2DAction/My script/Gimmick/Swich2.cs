using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swich2 : MonoBehaviour
{
    //定義する
    [SerializeField] Animator _MoveBlockAnimator;
    [SerializeField] string _animStateName2 = "MoveBlock";

    private void OnTriggerEnter2D(Collider2D collision) //コライダーがトリガーだったら反応する
    {
        if (collision.gameObject.tag == "Player1")//プレイヤー１
        {
            _MoveBlockAnimator.Play(_animStateName2);//アニメーションを再生する
        }
    }
}
