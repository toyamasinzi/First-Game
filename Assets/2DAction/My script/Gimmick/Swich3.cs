using UnityEngine;

public class Swich3: MonoBehaviour
{
    //��`����
    [SerializeField] Animator danroAnimator;
    [SerializeField] string animStateName = "Fireplace";

    private void OnTriggerEnter2D(Collider2D collision) //�R���C�_�[���g���K�[�������甽������
    {
        if (collision.gameObject.tag == "Player1" || collision.transform.tag == "Player2")//�v���C���[�P�܂��̓v���C���[�Q
        {
            danroAnimator.Play(animStateName);//�A�j���[�V�������Đ�����

        }
    }
}
