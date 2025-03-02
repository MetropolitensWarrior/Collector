using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverScreen;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Lava"))
        {
            Debug.Log("GameOver");
            gameOverScreen.SetActive(true);
        }

        else if(collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("GameOver");
            gameOverScreen.SetActive(true);

        }
    }
    private void Start()
    {
        gameOverScreen.SetActive(false);
    }
}
