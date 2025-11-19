using System.Security.Claims;
using UnityEngine;
using System.Collections.Generic;
using NUnit.Framework;
using System.Collections;
using System.Security.Principal;

delegate void EraseCallback();
public class CBTest : MonoBehaviour
{
    [SerializeField]
    GameObject ballprefab;

    List<Ball> balls = new();
    bool erasing;
    float eraseTime = 0.1f;

    int eraseCount;
    IEnumerator EraseBalls()
    {
        eraseCount = balls.Count;
        foreach (var ball in balls)
        {
            ball.EraseObj(
                () =>
                {
                    eraseCount--;
                }
                );
            yield return new WaitForSeconds(eraseTime);
        }
        balls.Clear();

        while (eraseCount > 0)
        {
            yield return null;
        }

        erasing = false;
    }

    public void EndErase()
    {
        eraseCount--;
    }
    void Update()
    {
        if (!erasing)
        {
            if (Input.GetMouseButtonDown(0))
            {
                var mpos = Input.mousePosition;
                mpos.z = 10f;
                var pos = Camera.main.ScreenToWorldPoint(mpos);

                var go = Instantiate(ballprefab, pos, Quaternion.identity);
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
}