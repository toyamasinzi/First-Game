using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swich2 : MonoBehaviour
{
    //��`����
    [SerializeField] Animator _MoveBlockAnimator;
    [SerializeField] string _animStateName2 = "MoveBlock";

    private void OnTriggerEnter2D(Collider2D collision) //�R���C�_�[���g���K�[�������甽������
    {
        if (collision.gameObject.tag == "Player1")//�v���C���[�P
        {
            _MoveBlockAnimator.Play(_animStateName2);//�A�j���[�V�������Đ�����
        }
    }
}
