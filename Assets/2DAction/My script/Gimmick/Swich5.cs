using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swich5 : MonoBehaviour
{
    //��`����
    [SerializeField] Animator _Moveanim;
    [SerializeField] string _animStateName = "MOve Destroy2";

    private void OnTriggerEnter2D(Collider2D collision) //�R���C�_�[���g���K�[�������甽������
    {
        if (collision.gameObject.tag == "Player1" || collision.transform.tag == "Player2")//�v���C���[�P�܂��̓v���C���[�Q
        {
            _Moveanim.Play(_animStateName);//�A�j���[�V�������Đ�����

        }
    }
}
