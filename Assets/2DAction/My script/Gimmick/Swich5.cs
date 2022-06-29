using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swich5 : MonoBehaviour
{
    //定義する
    [SerializeField] Animator _Moveanim;
    [SerializeField] string _animStateName = "MOve Destroy2";

    private void OnTriggerEnter2D(Collider2D collision) //コライダーがトリガーだったら反応する
    {
        if (collision.gameObject.tag == "Player1" || collision.transform.tag == "Player2")//プレイヤー１またはプレイヤー２
        {
            _Moveanim.Play(_animStateName);//アニメーションを再生する

        }
    }
}
