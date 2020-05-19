using UnityEngine;

public class Player : MonoBehaviour
{
    public float _speed;

    // Update is called once per frame
    void Update()
    {
        // Take in the users input.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Combine them into a Vector3
        // Vector3 can be initialised with only the x and y -axis, 
        // which we will do since we have no need for the z-axis
        Vector3 input = new Vector3(horizontalInput, verticalInput);

        // Multiply the current input values by the speed parameter
        Vector3 movement = input * _speed;

        // Multiply the movement vector by the speed parameter and then Time.Deltatime.
        // Time.DeltaTime gives you the time between the current and previous frame.
        // Using it makes your movement not be affected by the current frames per second.
        // You can test how it affects the movement by removing it from the code.
        //             Only this bit -> |        ↓       |
        Vector3 deltaMovement = movement * Time.deltaTime ;

        // Add the deltaMovement to the current position
        Vector3 newPosition = transform.position + deltaMovement;

        // Change the current position to the new position
        transform.position = newPosition;
    }
}
