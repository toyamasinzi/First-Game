using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swich4 : MonoBehaviour
{   
    //��`����
    [SerializeField] Animator Moves;�@
    [SerializeField] string animStateName = "Move";

    private void OnTriggerEnter2D(Collider2D collision) //�R���C�_�[���g���K�[�������甽������
    {
        if (collision.gameObject.tag == "Player1" || collision.transform.tag == "Player2")//�v���C���[�P�܂��̓v���C���[�Q
        {
            Moves.Play(animStateName);//�A�j���[�V�������Đ�����
          
        }
    }
}
