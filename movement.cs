// please name your script movement first to make it work.

using UnityEngine

public class movement : MonoBehaviour
{
    public Rigidbody rb // drag your RigidBody component  in the editor where rb is  written.

    public float forwardForce = 2000f; // this sets our forward force 2000-floats which you can change anytime.
    public float sidewaysForce = 500f; // this sets our Sideways force 500-floats which you can change anytime.

    void void FixedUpdate() // checks the updates once per frame
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // this adds a forward force on our rigid body / player.

        if (Input.GetKey("d")) // this checks that the user presses D key on keyboard.
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0 ForceMode.VelocityChange); // this enables our player to move on left side.
        }

        if (Input.GetKey("a")) // this checks that the user presses A key on keyboard.
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0 ForceMode.VelocityChange); // this enables our player to move on left side.
        }
    }
}