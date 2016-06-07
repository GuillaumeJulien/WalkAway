using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RAGestionner : MonoBehaviour {
    public GameObject imageUi;
    public GameObject infoTarget;
    public GameObject animatorDetect;
    public GameObject popinDetect;
    public string analizingText;

    private Text mTextInfo;
    private ObjetRa mObjetRa;
    private Viseur mViseur;
    private bool mpressure;
    private double mPressureTime;
    private GameObject mTextGameobjet;
    private Image mBackgroundInfo;
    private Animator animateDetect;
    private Animator animatePopin;
    private string mObjetRaInfo;

    // Use this for initialization
    void Start () {

        animateDetect = animatorDetect.GetComponent<Animator>();
        animatePopin = popinDetect.GetComponent<Animator>();
        mObjetRa = GetComponent<ObjetRa>();
        mViseur = imageUi.GetComponent<Viseur>();
        mTextInfo = infoTarget.GetComponentInChildren<Text>();
        mViseur.SensRotate = -15;
        mBackgroundInfo = infoTarget.GetComponent<Image>();
        mObjetRaInfo = mObjetRa.TextDescription;
        mTextInfo.text = mObjetRaInfo;


    }
	
	// Update is called once per frame
	void Update () {
        if (mpressure)
        {
            mObjetRa.IsAnalizing = true;
            StartCoroutine(AnimateRaUi());
            StartCoroutine(AnlizeObject());
        }
    }
    void OnMouseDown()
    {

        mViseur.SensRotate = 675;
        mpressure = true;

    }
    void OnMouseUp()
    {
        mViseur.SensRotate = -15;
        mpressure = false;
        StopAllCoroutines();
        if (mObjetRa.IsAnalized)
        {
            StartCoroutine(FadeOutUI());
        }
    }
    IEnumerator AnlizeObject()
    {
        yield return new WaitForSeconds(0.5f);
        mViseur.StopRotate();
        mObjetRa.IsAnalized = true;
        
    }
    IEnumerator AnimateRaUi()
    {
        animatePopin.SetBool("analized", false);
        animateDetect.SetBool("analized", false);
        animateDetect.SetBool("analizing", true);
        yield return new WaitForSeconds(animateDetect.GetCurrentAnimatorStateInfo(0).length-0.5f);
        animatePopin.SetBool("analizing", true);
        StartCoroutine(FadeInText());
    }
    IEnumerator FadeOutUI()
    {
        animatePopin.SetBool("analizing", false);
        animateDetect.SetBool("analizing", false);
        animateDetect.SetBool("analized", true);
        yield return new WaitForSeconds(animateDetect.GetCurrentAnimatorStateInfo(0).length-0.5f);
        animatePopin.SetBool("analized", true);
        mTextInfo.CrossFadeAlpha(0f, 0.5f, false);
    }
    IEnumerator FadeInText()
    {
        Debug.Log(mTextInfo.text);
        yield return new WaitForSeconds(animateDetect.GetCurrentAnimatorStateInfo(0).length - 0.5f);
        mTextInfo.CrossFadeAlpha(1f, 0.5f, false);
    }

}
