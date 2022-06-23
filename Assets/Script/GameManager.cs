using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject egg_prefab;
    public Basket basket;
    public Text score;
    public Text health;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEgg",2,2);
    }

    // Update is called once per frame
    void Update()
    {
        score.text = basket.score.ToString();
        health.text = basket.health.ToString(); 
    }

    void SpawnEgg()
    {
        float eggRangeX = Random.Range(-8f, 8f);
        Instantiate(egg_prefab, new Vector3(eggRangeX, 5.5f, 0), Quaternion.identity);
    }

    public void StopSpawning()
    {
        CancelInvoke();
    }
}
