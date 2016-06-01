using UnityEngine;
using System.Collections;

public class RAGestionner : MonoBehaviour {
    public GameObject imageUi;
    public GameObject infoTarget;
    private GameObject mTextInfo;
    private ObjetRa mObjetRa;
    private Viseur mViseur;
    private bool mpressure;
    private double mPressureTime;

    // Use this for initialization
    void Start () {
        mObjetRa = GetComponent<ObjetRa>();
        mViseur = imageUi.GetComponent<Viseur>();
        mTextInfo = imageUi.GetComponentInChildren<GameObject>();
        
	}
	
	// Update is called once per frame
	void Update () {
        if (mpressure)
        {
            mPressureTime += 1;
            if(mPressureTime > 50)
            {
                
            }
        }
        else
        {
            mPressureTime = 0;
        }
	}
    void OnMouseDown()
    {

        mViseur.ToggleRotate();
        mpressure = true;

    }
    void OnMouseUp()
    {
        mViseur.ToggleRotate();
        mpressure = false;
    }

}
