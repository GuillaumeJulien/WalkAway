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
            Debug.Log(mPressureTime);
            //mTextInfo.text = analizingText;
            mPressureTime += 1;
            Debug.Log(mPressureTime);
            if (mPressureTime > 50)
            {
                mObjetRa.IsAnalized = true;
                mTextInfo.text = mObjetRa.TextDescription;
                mViseur.StopRotate();
            }            
            else
            {
                mObjetRa.IsAnalizing = true;
            }
            
        }
        else
        {
            if (mPressureTime > 0)
            {
                mPressureTime -= 1;
            }
        }
        mBackgroundInfo.fillAmount = (float)mPressureTime / 50;
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
