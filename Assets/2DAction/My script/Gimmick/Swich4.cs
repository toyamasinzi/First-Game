using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swich4 : MonoBehaviour
{   
    //��`����
    [SerializeField] Animator _Moves;�@
    [SerializeField] string _animStateName = "Move";

    private void OnTriggerEnter2D(Collider2D collision) //�R���C�_�[���g���K�[�������甽������
    {
        if (collision.gameObject.tag == "Player1" || collision.transform.tag == "Player2")//�v���C���[�P�܂��̓v���C���[�Q
        {
            _Moves.Play(_animStateName);//�A�j���[�V�������Đ�����
          
        }
    }
}
