using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    //Used to jump from one scene to another by giving it the name
    //of the scene you want to jump to
    public void LoadLevel(string levelName)
    {
        Debug.Log("Level Load Requested for: " + levelName);
        SceneManager.LoadScene(levelName);
    }

    //Closes the application
    public void EndGame()
    {
        Debug.Log("Game Finished");
        Application.Quit();
    }
}
