using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy2 : MonoBehaviour
{
    [SerializeField] GameObject _player2; //オブジェクトを参照する
    [SerializeField] GameObject _Light;
    [SerializeField] string _Scene = "GameOver";
    [SerializeField] float _speed = 1f;
    [SerializeField] float _tim = 0;
    [SerializeField] int _count = 3;
    [SerializeField] int _count2 = 6;

    private void Update()
    {
        _tim += Time.deltaTime;

        if (_tim > _count)
        {
            _Light.SetActive(true);

            if (_tim > _count2)
            {
                _Light.SetActive(false);
                _tim = 0;
            }
        }
    }
    void FixedUpdate()
    {
        //プレイヤー-敵キャラの位置関係から方向を取得し、速度を一定化
        Vector2 _targeting = (_player2.transform.position - this.transform.position).normalized;
        //プレイヤー追う
        this.GetComponent<Rigidbody2D>().velocity = new Vector2((_targeting.x * _speed), (_targeting.y * _speed));
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player1" || collision.gameObject.tag == "Player2")
        {
            // Destroy(collision.gameObject, 0.01f);
            SceneManager.LoadScene(_Scene);
        }
        else if (collision.gameObject.tag == "Delite")
        {
            Destroy(collision.gameObject, 2f);
        }
    }
}
