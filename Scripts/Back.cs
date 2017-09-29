using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour {

    public int sceneIndex;

	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.Joystick1Button1))
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
