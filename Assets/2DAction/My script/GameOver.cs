using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] string Scene = "GameOver";
    private void OnCollisionEnter2D(Collision2D collision)
    {
     if(gameObject.tag == "Destroy")
        {
            SceneManager.LoadScene(Scene);
        }
    }
}