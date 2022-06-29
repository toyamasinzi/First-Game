using UnityEngine;

public class Player2 : MonoBehaviour
{
    //インスペクターで設定する
    [SerializeField] float _speed;
    public Animator _anim;
    public bool _isKey = false;
    /*
    private string playerName = "Player2";
    private bool NowPlayer = false;
    */
    float _h = 0;
    float _v = 0;
    private Rigidbody2D _rb2d;
    private Vector2 _dir = new Vector2(0, 0);
    private Vector2 _lastdir = new Vector2(0, -1);


    public bool _move;
   // public int dir;
    void Start()
    {
        _anim = GetComponent<Animator>();
        _rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()

    {
        _h = Input.GetAxisRaw("Player2Horizontal");
        _v = Input.GetAxisRaw("Player2Vertical");
        _dir = new Vector2(_h, _v);

        _rb2d.velocity = _dir.normalized * _speed;
        /*if (this.gameObject.tag == playerName)
         {
             //操作
             Vector2 position = transform.position;
             move = true;
             if (Input.GetKey("up"))
             {
                 position.y += speed * Time.deltaTime;
                 dir = 1;
             }
             else if (Input.GetKey("right"))
             {
                 position.x += speed * Time.deltaTime;
                 dir = 2;
             }
             else if (Input.GetKey("down"))
             {
                 position.y -= speed * Time.deltaTime;
                 dir = 3;
             }
             else if (Input.GetKey("left"))
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
        /* if (Input.GetKey("e") && !NowPlayer)//Eキーを押すとプレイヤー1に変わる
         {
             playerName = "Player1";
             NowPlayer = true;
         }
         else if (Input.GetKey("e") && NowPlayer)
         {
             playerName = "Player2";
             NowPlayer = false;
         }*/
    }
    private void LateUpdate()
    {
        Animate();
    }
    private void Animate()
    {
        if (Mathf.Abs(_dir.x) > 0.5f)
        {
            _lastdir.x = _dir.x;
            _lastdir.y = 0;
        }
        if (Mathf.Abs(_dir.y) > 0.5f)
        {
            _lastdir.y = _dir.y;
            _lastdir.x = 0;
        }
        _anim.SetFloat("x", _dir.x);
        _anim.SetFloat("y", _dir.y);
        _anim.SetFloat("StopMoveX", _lastdir.x);
        _anim.SetFloat("StopMoveY", _lastdir.y);
        _anim.SetFloat("Input", _dir.magnitude);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out KeyDestroy keyCs)) 
        {
            _isKey = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Door" && _isKey) 
        {
            Destroy(collision.gameObject);
        }
    }
}
