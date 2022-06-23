using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    [SerializeField]
    float speed;
    float xBound;

    public int score = 0;
    public int health = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Egg")
        {
            score += 1;
            Destroy(collision.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
        }

        float currentXPos = transform.position.x; 
        currentXPos = Mathf.Clamp(currentXPos, -7f, 7f);
        transform.position = new Vector3(currentXPos, transform.position.y, transform.position.z);
    }
}
