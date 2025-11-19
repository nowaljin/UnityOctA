using System;
using UnityEngine;

public class Ball : MonoBehaviour
{
    bool zoom;
    float timer;
    float ZoomTime = 1f;
    Action callback;

    void Update()
    {
        if (zoom)
        {
            timer += Time.deltaTime;
            if (timer < ZoomTime)
            {
                var size = Mathf.Lerp(1f, 0f, timer / ZoomTime);
                transform.localScale = Vector3.one * size;
            }
            else
            {
                callback?.Invoke();
                Destroy(gameObject);
            }
        }
    }

    public void EraseObj(Action cb)
    {
        callback = cb;
        zoom = true;
        timer = 0f; 
    }
}