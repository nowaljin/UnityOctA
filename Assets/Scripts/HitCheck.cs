using UnityEngine;
using UnityEngine.EventSystems;

public class HitCheck : MonoBehaviour
{
    HItObj lastHit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            HItObj h = hit.transform.GetComponent<HItObj>();
            Renderer r = hit.transform.GetComponent<Renderer>();
            if (r != null)
            {
                if (lastHit != null)
                {
                    lastHit.MouseOff();
                }
                lastHit = h;
                lastHit.MouseOn();
            }
        }
        else
        {
            if (lastHit != null)
            {
                lastHit.MouseOff();
                lastHit = null;
            }


        }
    }
}