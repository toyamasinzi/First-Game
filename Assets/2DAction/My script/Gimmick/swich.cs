using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swich : MonoBehaviour
{   
    //��`����
    [SerializeField] Animator _shelfAnimator;�@
    [SerializeField] string _animStateName = "ShelfAnim";

    private void OnTriggerEnter2D(Collider2D collision) //�R���C�_�[���g���K�[�������甽������
    {
        if (collision.gameObject.tag == "Player1" || collision.transform.tag == "Player2")//�v���C���[�P�܂��̓v���C���[�Q
        {
            _shelfAnimator.Play(_animStateName);//�A�j���[�V�������Đ�����
          
        }
    }
}
