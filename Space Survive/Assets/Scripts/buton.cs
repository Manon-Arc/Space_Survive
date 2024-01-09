using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // La scène sera chargée lorsque le jeu démarre
    }

    // Update is called once per frame
    void Update()
    {
        // Vérifie si le bouton est pressé (changez "Fire1" au nom du bouton que vous utilisez)
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Button pressed");
            OnButtonClick();
        }
    }

    // Méthode appelée lorsque le bouton est pressé
    public void OnButtonClick()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
