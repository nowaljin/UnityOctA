using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField]
    GameObject bulletPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            var go = Instantiate(bulletPrefab, ray.origin, Quaternion.identity);
            var rb = go.GetComponent<Rigidbody>();
            rb.linearVelocity = ray.direction * 20f;
            Destroy(go, 5f);

        }
    }
}
