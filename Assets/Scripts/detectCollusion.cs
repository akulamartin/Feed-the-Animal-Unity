using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollusion : MonoBehaviour
{
    private TheGameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<TheGameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Food"))
        {
            gameObject.GetComponent<AnimalHunger>().FeedAnimal(1);
            
        }
    }
}
