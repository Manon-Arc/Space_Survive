using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        float speed = 10;

        Vector3 movement = new Vector3(moveX, moveY);
        transform.Translate(movement * speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("aste"))
        {
            PlayerPrefs.SetInt("Score", GameObject.Find("compteur").GetComponent<ScoreManager>().score);
            SceneManager.LoadScene("GameOver");
        }
    }
}
