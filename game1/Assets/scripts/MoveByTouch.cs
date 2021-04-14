
using UnityEngine;
using System.Collections;
public class MoveByTouch : MonoBehaviour
{
    private float speed = 0.01f;
    private Touch touch;
    public bool grounded = true;
    public float jumpPower = 5;

    // Update is called once per frame

    void FixedUpdate()
    {
        StartCoroutine(BallJump());
    }



    IEnumerator BallJump()
    {
       
        GameManager.spee += 0.00004f;
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + GameManager.spee);

        if (Input.touchCount > 0)
        {
            if (!grounded && GetComponent<Rigidbody>().velocity.y == 0)
            {
                grounded = true;
            }
            if (Input.GetMouseButtonDown(0) && grounded == true)
            {
                GetComponent<Rigidbody>().AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
                grounded = false;
            }
        }


        touch = Input.GetTouch(0);


        if (touch.phase == TouchPhase.Moved)
        {
            transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speed, transform.position.y, transform.position.z);
        }
        yield return new WaitForSeconds(10.0f);
    }
}