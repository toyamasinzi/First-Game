using UnityEngine;

public class Player2 : MonoBehaviour
{
    //インスペクターで設定する
    [SerializeField] float speed;
    [SerializeField] private Player _playerCs;
    public Animator anim;
    public bool isKey = false;
    /*
    private string playerName = "Player2";
    private bool NowPlayer = false;
    */
    float h = 0;
    float v = 0;
    private Rigidbody2D rb2d;
    private Vector2 dir = new Vector2(0, 0);
    private Vector2 lastdir = new Vector2(0, -1);


    public bool move;
   // public int dir;
    void Start()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()

    {
        h = Input.GetAxisRaw("Player2Horizontal");
        v = Input.GetAxisRaw("Player2Vertical");
        dir = new Vector2(h, v);

        rb2d.velocity = dir.normalized * speed;
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
        if (Mathf.Abs(dir.x) > 0.5f)
        {
            lastdir.x = dir.x;
            lastdir.y = 0;
        }
        if (Mathf.Abs(dir.y) > 0.5f)
        {
            lastdir.y = dir.y;
            lastdir.x = 0;
        }
        anim.SetFloat("x", dir.x);
        anim.SetFloat("y", dir.y);
        anim.SetFloat("StopMoveX", lastdir.x);
        anim.SetFloat("StopMoveY", lastdir.y);
        anim.SetFloat("Input", dir.magnitude);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out KeyDestroy keyCs)) 
        {
            isKey = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Door" && isKey) 
        {
            Destroy(collision.gameObject);
        }
    }
}
