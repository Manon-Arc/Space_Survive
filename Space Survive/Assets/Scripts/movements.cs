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
        float speed = 30;

        //float max_X = SampleScene.max.x;
        //float min_X = SampleScene.min.x;
        //float max_Y = SampleScene.max.y;
        //float minY = SampleScene.min.y;
        Debug.Log("coordo ship en X : " + transform.position.x);
        Debug.Log("coordo ship en Y : " + transform.position.y);
        //Debug.Log("max X : " + max_X);
        //Debug.Log("max Y : " + max_Y);

        Vector3 movement = new Vector3(moveX, moveY);
        transform.Translate(movement * speed * Time.deltaTime);

        /*if (max_X > transform.position.x && min_X < transform.position.x && max_Y > transform.position.y && minY < transform.position.y)
        {
            Debug.Log("toto");

        }*/

    }
}
