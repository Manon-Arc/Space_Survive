using System.Collections;
using System.Collections.Generic;

//using UnityEditor.SearchService;
using UnityEngine.SceneManagement;
using UnityEngine;

public class movements : MonoBehaviour
{
    public Scene SampleScene;

    public BoxCollider2D area;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        float speed = 10;

        Vector3 movement = new Vector3(moveX, moveY);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
