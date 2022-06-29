using UnityEngine;

public class Swich3: MonoBehaviour
{
    //定義する
    [SerializeField] Animator _danroAnimator;
    [SerializeField] string _animStateName = "Fireplace";

    private void OnTriggerEnter2D(Collider2D collision) //コライダーがトリガーだったら反応する
    {
        if (collision.gameObject.tag == "Player1" || collision.transform.tag == "Player2")//プレイヤー１またはプレイヤー２
        {
            _danroAnimator.Play(_animStateName);//アニメーションを再生する

        }
    }
}
