using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneUI : MonoBehaviour
{
    public void Feminine()
    {

        SceneManager.LoadScene("Female");

    }

    public void Masculine()
    {

        SceneManager.LoadScene("Male");

    }


    // ui assets https://fshift.itch.io/gradient-renpy-gui-kit

}
