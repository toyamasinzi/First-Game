using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //インスペクターで設定する
   [SerializeField] float speed;//速度
    public Animator anim;
    float h = 0;
    float v = 0;

    /*private string playerName = "Player1";
    private bool NowPlayer = false;*/
    private Rigidbody2D rb2d;
    public bool move;
    //public int dir;
    private Vector2 dir = new Vector2(0, 0);
    private Vector2 lastdir = new Vector2(0, -1);

 
    void Start()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        dir = new Vector2(h, v);

        rb2d.velocity = dir.normalized * speed;
        
        //Animate();

        //if (this.gameObject.tag == playerName)
        {/*
            //操作
            Vector2 position = transform.position;
            move = true;
            if (Input.GetKey("w"))
            {
                position.y += speed * Time.deltaTime;
                dir = 1;
            }
            else if (Input.GetKey("d"))
            {
                position.x += speed * Time.deltaTime;
                dir = 2;
            }
            else if (Input.GetKey("s"))
            {
                position.y -= speed * Time.deltaTime;
                dir = 3;
            }
            else if (Input.GetKey("a"))
            {
                position.x -= speed * Time.deltaTime;
                dir = 4;
            }
            else
            {
                move = false;
            }

            switch (dir)//三項演算子
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
        }*/

            /* if (Input.GetKey("q") && !NowPlayer)//Qキーを押すとプレイヤー2に変わる
             {
                 playerName = "Player2";
                 NowPlayer = true;
             }
             else if(Input.GetKey("q") && NowPlayer)
             {
                 playerName = "Player1";
                 NowPlayer = false;
             }*/
        }
    }
    private void LateUpdate()
    {
        Animate();
    }
    private void Animate()
    {
        if(Mathf.Abs(dir.x) > 0.5f)
        {
            lastdir.x = dir.x;
            lastdir.y = 0;
        }
        if(Mathf.Abs(dir.y) > 0.5f)
        {
            lastdir.y = dir.y;
            lastdir.x = 0;
        }
        anim.SetFloat("x", dir.x);
        anim.SetFloat("y", dir.y);
        anim.SetFloat("StopMoveX",lastdir.x);
        anim.SetFloat("StopMoveY", lastdir.y);
        anim.SetFloat("Input", dir.magnitude);
    }

    
}
