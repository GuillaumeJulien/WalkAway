using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System;

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
    public void LoadSceneAndClean(string scene)
    {
        activeScene = SceneManager.GetActiveScene();
        SceneManager.UnloadScene(activeScene.name);
        SceneManager.LoadScene(scene);
    }
    public void LoadSceneAscyn(string scene)
    {
        StartCoroutine(LoadLeveCoroutine(scene));
    }

    private IEnumerator LoadLeveCoroutine(string scene)
    {
        AsyncOperation async = SceneManager.LoadSceneAsync(scene);

        yield return async;
    }

    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
