using UnityEngine;
using System.Collections;

public class RotateAnimator : MonoBehaviour
{
    protected Transform pTransform;
    protected int pSensRotate;
    private bool isIdle;
    public int idle;
    public int SensRotate
    {
        get { return pSensRotate; }
        set { pSensRotate = value; }
    }

    /// <summary>
    /// Change le sens de rotation
    /// </summary>
    /// 
    public virtual void ToggleRotate()
    {
            if (isIdle)
            {
                pSensRotate = -pSensRotate / 45;
                isIdle = false;
            }
            else
            {
                pSensRotate = -pSensRotate * 45;

                isIdle = true;
            }
       
    }
    /// <summary>
    /// Arrête la rotation 
    /// </summary>
    public virtual void StopRotate()
    {
        pSensRotate = 0;
    }

    /// <summary>
    /// Fais faire une rotation a l'objet, la vitesse dépend de pSensRotate
    /// </summary>
    public virtual void RotateZ()
    {
        pTransform.Rotate(new Vector3(0, 0, pSensRotate) *Time.deltaTime);
    }

}
