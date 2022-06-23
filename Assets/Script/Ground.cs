using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public Basket basket_script;
    public GameManager gm_script;
    public GameObject h1, h2, h3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Egg")
        {
            Destroy(collision.gameObject);
            basket_script.health -= 1;
        }

        if (basket_script.health == 0)
        {
            gm_script.StopSpawning();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(basket_script.health)
        {
            case 0: 
                h1.SetActive(false);
                h2.SetActive(false);
                h3.SetActive(false);
                break;
            case 1:
                h1.SetActive(true);
                h2.SetActive(false);
                h3.SetActive(false);
                break;
            case 2:
                h1.SetActive(true);
                h2.SetActive(true);
                h3.SetActive(false);
                break;
            case 3:
                h1.SetActive(true);
                h2.SetActive(true);
                h3.SetActive(true);
                break;
        }    
    }
}
