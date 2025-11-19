using UnityEngine;
using UnityEngine.EventSystems;
public class HitObjA : MonoBehaviour , IHitAction
{
    float scale = 1f;
    public void HitAction()
    {
        scale += 0.1f;
        transform.localScale =Vector3.one*scale;
       
    }
}