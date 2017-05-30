using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour {

	public void LoadLevel(string name)
    {
        Debug.Log("Level load requested."+name);
        Application.LoadLevel(name);
    }

    public void quitRequest()
    {
        Debug.Log("I want to quit.");
        Application.Quit();
    }
}
