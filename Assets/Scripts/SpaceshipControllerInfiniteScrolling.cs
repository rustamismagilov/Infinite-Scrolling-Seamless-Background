using UnityEngine;
using System.Collections;

public class SpaceshipControllerInfiniteScrolling : MonoBehaviour
{
    [SerializeField] float _speed = 5f; // The speed at which the spaceship moves

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();
    }

    // Calculates the movement of the spaceship based on player input
    void CalculateMovement()
    {
        // Get the horizontal and vertical input from the player
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Create a new vector representing the direction of the movement
        Vector3 direction = new(horizontalInput, verticalInput, 0);

        // Move the spaceship by a specified amount of input in a given direction
        transform.Translate(_speed * Time.deltaTime * direction);

        // Limit the position of the spaceship to keep it within the screen boundaries
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8.4f, 8.4f), Mathf.Clamp(transform.position.y, -4.5f, 4.5f), 0);
    }
}
