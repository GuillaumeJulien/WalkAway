using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GeneralGestionner : MonoBehaviour {
    private Scene activeScene;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void LoadScene(string scene)
    {
        activeScene = SceneManager.GetActiveScene();
        SceneManager.UnloadScene(activeScene.name);
        SceneManager.LoadScene(scene);
    }
}
