using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    //インスペクターで設定する
    public float speed;//速度
    public Animator anim;

    private string playerName = "Player2";
    private bool NowPlayer = false;


    public bool move;
    public int dir;
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    void Update()

    {
        if (this.gameObject.tag == playerName)
        {
            //操作
            Vector2 position = transform.position;
            move = true;
            if (Input.GetKey("up"))//上の矢印
            {
                position.y += speed * Time.deltaTime;
                dir = 1;
            }
            else if (Input.GetKey("right"))//右の矢印
            {
                position.x += speed * Time.deltaTime;
                dir = 2;
            }
            else if (Input.GetKey("down"))//下の矢印
            {
                position.y -= speed * Time.deltaTime;
                dir = 3;
            }
            else if (Input.GetKey("left"))//左の矢印
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
                    anim.Play(move ? "Player2 up" : "Player2 idre up");
                    break;
                case 2:
                    anim.Play(move ? "Player2 rigth" : "Player2 idre rigth");
                    break;
                case 3:
                    anim.Play(move ? "Player2 down" : "Player2 idre down");
                    break;
                case 4:
                    anim.Play(move ? "Player2 left" : "Player2 idre left");
                    break;
                default:
                    break;
            }
            transform.position = position;
        }
        if (Input.GetKey("e") && !NowPlayer)//Eキーを押すとプレイヤー1に変わる
        {
            playerName = "Player1";
            NowPlayer = true;
        }
        else if (Input.GetKey("e") && NowPlayer)
        {
            playerName = "Player2";
            NowPlayer = false;
        }
    }
}
