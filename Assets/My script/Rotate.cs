using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 360) * Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Õ“Ë‚µ‚½‘Šè‚Éplayerƒ^ƒO‚ª•t‚¢‚Ä‚é‚Æ‚«
        if (collision.gameObject.tag == "Player1" || collision.gameObject.tag == "Player2")
        {
            //0.2•b‚ÅÁ‚¦‚é
            Destroy(collision.gameObject, 0.01f);
        }
    }
}
