using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector2 xdirection;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        xdirection = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        rb.velocity = xdirection * 900 * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "bad")
        {
            ResetBall();
        }
    }

    void ResetBall()
    {
        // إعادة إنشاء الكرة من جديد في الموقع الأصلي أو الموقع الذي تحدده
        // هنا قمت بإعادة إنشاءها في الموقع الأصلي (0, 0)
        Instantiate(gameObject, Vector3.zero, Quaternion.identity);
        // تدمير الكرة الحالية
        Destroy(gameObject);
    }
}
