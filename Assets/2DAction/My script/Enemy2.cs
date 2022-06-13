using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy2 : MonoBehaviour
{
    [SerializeField] GameObject player2; //オブジェクトを参照する
    [SerializeField] string Scene = "GameOver";
    [SerializeField] float speed = 1f;

    void FixedUpdate()
    {
        //プレイヤー-敵キャラの位置関係から方向を取得し、速度を一定化
        Vector2 targeting = (player2.transform.position - this.transform.position).normalized;
        //プレイヤー追う
        this.GetComponent<Rigidbody2D>().velocity = new Vector2((targeting.x * speed), (targeting.y * speed));
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player1" || collision.gameObject.tag == "Player2")
        {
            // Destroy(collision.gameObject, 0.01f);
            SceneManager.LoadScene(Scene);
        }
        else if (collision.gameObject.tag == "Delite")
        {
            Destroy(collision.gameObject, 2f);
        }
    }
}
