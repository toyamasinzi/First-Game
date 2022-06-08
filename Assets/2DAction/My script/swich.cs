using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swich : MonoBehaviour
{   
    //定義する
    [SerializeField] Animator shelfAnimator;　
    [SerializeField] string animStateName = "ShelfAnim";

    private void OnTriggerEnter2D(Collider2D collision) //コライダーがトリガーだったら反応する
    {
        if (collision.gameObject.tag == "Player1" || collision.transform.tag == "Player2")//プレイヤー１またはプレイヤー２
        {
            shelfAnimator.Play(animStateName);//アニメーションを再生する
          
        }
    }
}
