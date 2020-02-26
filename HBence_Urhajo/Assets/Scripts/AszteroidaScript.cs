using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AszteroidaScript : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float MaxThrust;
    public float MaxTorque;
    public float screenTop;
    public float screenBottom;
    public float screenLeft;
    public float screenRight;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 thrust = new Vector2(Random.Range(-MaxThrust, MaxThrust), Random.Range(-MaxThrust, MaxThrust));
        float torque = Random.Range(-MaxTorque, MaxTorque);

        rigidbody.AddForce(thrust);
        rigidbody.AddTorque(torque);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        if (transform.position.y > screenTop)
        {
            newPos.y = screenBottom;
        }

        if (transform.position.y < screenBottom)
        {
            newPos.y = screenTop;
        }

        if (transform.position.x > screenRight)
        {
            newPos.x = screenLeft;
        }

        if (transform.position.x < screenLeft)
        {
            newPos.x = screenRight;
        }

        transform.position = newPos;
    }
}
