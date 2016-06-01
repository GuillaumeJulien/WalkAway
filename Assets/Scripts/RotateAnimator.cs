using UnityEngine;
using System.Collections;

public class RotateAnimator : MonoBehaviour
{
    protected Transform pTransform;
    protected int pSensRotate;
    private bool isIdle;

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
    /// Fais faire une rotation a l'objet, la vitesse dépend de pSensRotate
    /// </summary>
    public virtual void RotateZ()
    {
        pTransform.Rotate(new Vector3(0, 0, pSensRotate) *Time.deltaTime);
    }

}
