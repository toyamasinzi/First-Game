using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject _player1;//�I�u�W�F�N�g���Q�Ƃ���
    [SerializeField] GameObject _Light;
    [SerializeField] GameObject _audio;
    [SerializeField] string _Scene = "GameOver";
    [SerializeField] float _speed = 1f;
    [SerializeField] float _tim = 0;
    [SerializeField] int _count = 3;
    [SerializeField] int _count2 = 6;

    private AudioSource _ad;

    private void Start()
    {
        _ad = GetComponent<AudioSource>();
    }

    private void Update()
    {
        _tim += Time.deltaTime;

        if(_tim > _count)
        {
            _Light.SetActive(true);
            _audio.SetActive(true);
            
            if (_tim > _count2)
            {
                _Light.SetActive(false);
                _audio.SetActive(false);
                _tim = 0;
            }
        }
    }
    void FixedUpdate()
    {
        //�v���C���[-�G�L�����̈ʒu�֌W����������擾���A���x����艻
        Vector2 _targeting = (_player1.transform.position - this.transform.position).normalized;
        //�v���C���[�ǂ�
        this.GetComponent<Rigidbody2D>().velocity = new Vector2((_targeting.x * _speed), (_targeting.y * _speed));

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player1" || collision.gameObject.tag == "Player2")
        {
            // Destroy(collision.gameObject, 0.01f);
            SceneManager.LoadScene(_Scene);
        }
       else if(collision.gameObject.tag == "Delite")
        { 
            Destroy(collision.gameObject, 2f);
        }
    }

}
