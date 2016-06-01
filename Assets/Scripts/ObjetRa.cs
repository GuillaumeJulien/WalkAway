using UnityEngine;
using System.Collections;

public class ObjetRa : MonoBehaviour {
    public string textDescription;
    private bool mAnalizing;
    private bool mAnalized;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public string GetDescription()
    {
        return textDescription;
    }

    public bool IsAnalized()
    {
        return mAnalized;
    }
}
