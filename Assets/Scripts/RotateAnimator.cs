using UnityEngine;
using System.Collections;

public class RotateAnimator : MonoBehaviour
{
    protected Transform pTransform;
    protected int pSensRotate;
    /// <summary>
    /// Change le sens de rotation
    /// </summary>
    /// 
    public virtual void ToggleRotate()
    {
        pSensRotate = -pSensRotate;
    }

    /// <summary>
    /// Fais faire une rotation a l'objet, la vitesse dépend de pSensRotate
    /// </summary>
    public virtual void RotateZ()
    {
        pTransform.Rotate(new Vector3(0, 0, pSensRotate) *Time.deltaTime);
    }

}
