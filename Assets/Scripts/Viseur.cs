using UnityEngine;
using System.Collections;

public class Viseur : RotateAnimator
{
    private bool mHasTarget;
    private bool mIsAnalized;

	// Use this for initialization
	void Start () {
        idle = -15;
        pTransform = transform;
    }
	
	// Update is called once per frame
	void Update () {
        RotateZ();
    }
}
