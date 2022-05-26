using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour
{   
    //�C���X�y�N�^�[�Őݒ肷��
    public float speed;//���x
    public Animator anim;

    private string playerName = "Player1";
    private bool NowPlayer = false;

   public bool move;
   public int dir;
    void Start()
    {
        anim =  GetComponent<Animator>();

    }

    void Update()
    {
        if (this.gameObject.tag == playerName)
        {
            //����
            Vector2 position = transform.position;
            move = true;
            if (Input.GetKey("w"))//��̖��
            {
                position.y += speed * Time.deltaTime;
                dir = 1;
            }
            else if (Input.GetKey("d"))//�E�̖��
            {
                position.x += speed * Time.deltaTime;
                dir = 2;
            }
            else if (Input.GetKey("s"))//���̖��
            {
                position.y -= speed * Time.deltaTime;
                dir = 3;
            }
            else if (Input.GetKey("a"))//���̖��
            {
                position.x -= speed * Time.deltaTime;
                dir = 4;
            }
            else
            {
                move = false;
            }
            switch (dir)
            {
                case 1:
                    anim.Play(move ? "Player1  Up Animation" : "Idre up");
                    break;
                case 2:
                    anim.Play(move ? "Player1 Right Animation" : "Idre Rigth");
                    break;
                case 3:
                    anim.Play(move ? "Player1 Animation" : "Idle down");
                    break;
                case 4:
                    anim.Play(move ? "Player1  Left Animation" : "Idre Left");
                    break;
                default:
                    break;
            }
            transform.position = position;
        }

        if (Input.GetKey("q") && !NowPlayer)//Q�L�[�������ƃv���C���[2�ɕς��
        {
            playerName = "Player2";
            NowPlayer = true;
        }
        else if(Input.GetKey("q") && NowPlayer)
        {
            playerName = "Player1";
            NowPlayer = false;
        }
    }
}
