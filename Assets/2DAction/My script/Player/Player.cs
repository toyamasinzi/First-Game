using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //インスペクターで設定する
   [SerializeField] float _speed;//速度
    public Animator _anim;
    float _h = 0;
    float _v = 0;

    /*private string playerName = "Player1";
    private bool NowPlayer = false;*/
    private Rigidbody2D _rb2d;
    public bool _move;
    //public int dir;
    private Vector2 _dir = new Vector2(0, 0);
    private Vector2 _lastdir = new Vector2(0, -1);

 
    void Start()
    {
        _anim = GetComponent<Animator>();
        _rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _h = Input.GetAxisRaw("Horizontal");
        _v = Input.GetAxisRaw("Vertical");
        _dir = new Vector2(_h, _v);

        _rb2d.velocity = _dir.normalized * _speed;
        
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
        if(Mathf.Abs(_dir.x) > 0.5f)
        {
            _lastdir.x = _dir.x;
            _lastdir.y = 0;
        }
        if(Mathf.Abs(_dir.y) > 0.5f)
        {
            _lastdir.y = _dir.y;
            _lastdir.x = 0;
        }
        _anim.SetFloat("x", _dir.x);
        _anim.SetFloat("y", _dir.y);
        _anim.SetFloat("StopMoveX",_lastdir.x);
        _anim.SetFloat("StopMoveY", _lastdir.y);
        _anim.SetFloat("Input", _dir.magnitude);
    }

    
}
