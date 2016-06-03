using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RAGestionner : MonoBehaviour {
    public GameObject imageUi;
    public GameObject infoTarget;
    public string analizingText;

    private Text mTextInfo;
    private ObjetRa mObjetRa;
    private Viseur mViseur;
    private bool mpressure;
    private double mPressureTime;
    private GameObject mTextGameobjet;
    private Image mBackgroundInfo;

    // Use this for initialization
    void Start () {
        mObjetRa = GetComponent<ObjetRa>();
        mViseur = imageUi.GetComponent<Viseur>();
        mTextInfo = infoTarget.GetComponentInChildren<Text>();
        mViseur.SensRotate = -15;
        mBackgroundInfo = infoTarget.GetComponent<Image>();


    }
	
	// Update is called once per frame
	void Update () {
        if (mpressure)
        {
            mObjetRa.IsAnalizing = true;
            StartCoroutine(AnlizeObject());
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
    IEnumerator AnlizeObject()
    {
        yield return new WaitForSeconds(2);
        mViseur.StopRotate();
        mObjetRa.IsAnalized = true;
        
    }

}
