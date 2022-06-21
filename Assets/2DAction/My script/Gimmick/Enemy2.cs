using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy2 : MonoBehaviour
{
    [SerializeField] GameObject player2; //�I�u�W�F�N�g���Q�Ƃ���
    [SerializeField] GameObject right;
    [SerializeField] string Scene = "GameOver";
    [SerializeField] float speed = 1f;
    [SerializeField] float _tim = 0;
    [SerializeField] int count = 3;
    [SerializeField] int count2 = 6;

    private void Update()
    {
        _tim += Time.deltaTime;

        if (_tim > count)
        {
            right.SetActive(true);

            if (_tim > count2)
            {
                right.SetActive(false);
                _tim = 0;
            }
        }
    }
    void FixedUpdate()
    {
        //�v���C���[-�G�L�����̈ʒu�֌W����������擾���A���x����艻
        Vector2 targeting = (player2.transform.position - this.transform.position).normalized;
        //�v���C���[�ǂ�
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
