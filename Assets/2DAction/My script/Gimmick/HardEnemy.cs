using UnityEngine;
using UnityEngine.SceneManagement;

public class HardEnemy : MonoBehaviour
{
    [SerializeField] GameObject player1;//�I�u�W�F�N�g���Q�Ƃ���
    [SerializeField] GameObject right;
    [SerializeField] GameObject audio;
    [SerializeField] string Scene = "GameOverHard";
    [SerializeField] float speed = 1f;
    [SerializeField] float acclerator = 2;
    [SerializeField] float _tim = 0;
    [SerializeField] int count = 3;
    [SerializeField] int count2 = 6;
    private bool _sp = false;


    private void Update()
    {
        _tim += Time.deltaTime;

        if(_tim > count)
        {
            right.SetActive(true);
            audio.SetActive(true);
            _sp = true;

            if (_tim > count2)
            {
                _sp = false;
                right.SetActive(false);
                audio.SetActive(false);
                _tim = 0;
            }
        }
    }
    void FixedUpdate()
    {
        //�v���C���[-�G�L�����̈ʒu�֌W����������擾���A���x����艻
        Vector2 targeting = (player1.transform.position - this.transform.position).normalized;
        //�v���C���[�ǂ�
        this.GetComponent<Rigidbody2D>().velocity = new Vector2((targeting.x * speed), (targeting.y * speed));
        if( _sp == true)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2((targeting.x * acclerator), (targeting.y * acclerator));
        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player1" || collision.gameObject.tag == "Player2")
        {
            // Destroy(collision.gameObject, 0.01f);
            SceneManager.LoadScene(Scene);
        }
       else if(collision.gameObject.tag == "Delite")
        { 
            Destroy(collision.gameObject, 2f);
        }
    }

}
