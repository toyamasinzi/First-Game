using UnityEngine;

public class Audio : MonoBehaviour
{
   [SerializeField] AudioClip _se;
    private AudioSource _Adi;

    void Start()
    {
        _Adi = GetComponent<AudioSource>();
    }

    // �Ԃ��������ɉ���炷
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _Adi.PlayOneShot(_se);
    }
}