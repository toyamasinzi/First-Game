using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] float count = 2;
    [SerializeField] string Scene = "Game";
    private float timer = 0;
    bool istimer = false;
    void Update()
    {
        if (istimer)
        {
            timer += Time.deltaTime;
        }

        if(count < timer)
        { 
            SceneManager.LoadScene(Scene);
        }
    }

    public void StartTimer()
    {
        istimer = true;
    }
}
