using UnityEngine;

public class Swich3: MonoBehaviour
{
    //��`����
    [SerializeField] Animator _danroAnimator;
    [SerializeField] string _animStateName = "Fireplace";

    private void OnTriggerEnter2D(Collider2D collision) //�R���C�_�[���g���K�[�������甽������
    {
        if (collision.gameObject.tag == "Player1" || collision.transform.tag == "Player2")//�v���C���[�P�܂��̓v���C���[�Q
        {
            _danroAnimator.Play(_animStateName);//�A�j���[�V�������Đ�����

        }
    }
}
