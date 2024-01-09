using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buton : MonoBehaviour
{
 
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Button pressed");
            OnButtonClick();
        }
    }

    public void OnButtonClick()
    {
        SceneManager.LoadScene("Game");
    }
}
