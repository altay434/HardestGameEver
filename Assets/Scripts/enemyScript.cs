using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public int enemyYön = 2;
    public int enemy2Yön = 2;
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            collision.collider.transform.position = new Vector2(-1f, -7f);
        }
        if (collision.collider.tag == "wall")
        {
            if(tag == "enemy")
            {
                enemyYön *= -1;
            }
            if(tag == "enemy2")
            {
                enemy2Yön *= -1;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (tag == "enemy")
        {
            transform.Translate(Vector2.down * Time.deltaTime * enemyYön);
        }
        if (tag == "enemy2")
        {
            transform.Translate(Vector2.up * Time.deltaTime * enemy2Yön);
        }
    }
}
    
