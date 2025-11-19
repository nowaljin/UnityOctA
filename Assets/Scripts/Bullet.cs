using UnityEngine;

public class Bullet : MonoBehaviour
{
   private void OnCollisionEnter(Collision collision)
   {
      var hit = collision.gameObject.GetComponent<IHitAction>();
        if (hit !=null)
        {
            hit.HitAction();
        }
    }
}
