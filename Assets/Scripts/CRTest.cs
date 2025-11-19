using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CRTest : MonoBehaviour
{
    [SerializeField]
    GameObject ballPrefab;

    List<Ball> balls = new();
    bool erasing;
    float eraseTime = 0.1f;

    void Update()
    {
        if (!erasing)
        {
            if (Input.GetMouseButtonDown(0))
            {
                var mpos = Input.mousePosition;
                mpos.z = 10f;
                var pos = Camera.main.ScreenToWorldPoint(mpos);
                var go = Instantiate(ballPrefab, pos, Quaternion.identity);
                var ball = go.GetComponent<Ball>();
                balls.Add(ball);
            }

            if (Input.GetMouseButtonDown(1))
            {
                erasing = true;
                StartCoroutine(EraseBalls());
            }
        }
    }

    IEnumerator EraseBalls()
    {
        foreach (var ball in balls)
        {
            ball.EraseObj(() => { });                   
            yield return new WaitForSeconds(eraseTime);
        }
        balls.Clear();
        erasing = false;
    }
}