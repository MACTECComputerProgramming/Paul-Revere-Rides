
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< Updated upstream
        rb.AddForce(0, 200, 500);
=======
      
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void FixedUpdate()
    {
<<<<<<< Updated upstream
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
=======
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce, 0, 0);
        }
>>>>>>> Stashed changes
    }
}
