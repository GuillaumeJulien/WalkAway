using UnityEngine;
using System.Collections;

public class ObjetRa : MonoBehaviour {
    public string textDescription;
    private bool mIsAnalized;
    private bool mIsAnalizing;

    public bool IsAnalizing
    {
        get { return mIsAnalizing; }
        set { mIsAnalizing = value; }
    }

    public bool IsAnalized
    {
        get { return mIsAnalized; }
        set { mIsAnalized = value; }
    }
    public string TextDescription
    {
        get { return textDescription; }
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    

}
