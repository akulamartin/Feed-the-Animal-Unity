using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class destroyOutofBounds : MonoBehaviour
{
    public float topBound = 30;
    public float lowerBound = -10;
    // Start is called before the first frame update
    private float sideBound = 30;
    private TheGameManager gameManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<TheGameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x > sideBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x < -sideBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
