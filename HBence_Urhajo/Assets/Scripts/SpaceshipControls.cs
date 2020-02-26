using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipControls : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float thrust;
    public float turnThrust;
    private float thurstInput;
    private float turnInput;
    public float screenTop;
    public float screenBottom;
    public float screenLeft;
    public float screenRight;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(Vector3.forward * turnInput * Time.deltaTime * -turnThrust);






        thurstInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");

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

    void FixedUpdate()
    {
        rigidbody.AddRelativeForce(Vector2.up * thurstInput*2);
        //rigidbody.AddTorque(-turnInput);
    }
}
