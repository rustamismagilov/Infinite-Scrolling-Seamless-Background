using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    // A factor that controls the strength of the parallax effect
    public float parallax;      //Creating a parallax effect in the background of a 3D scene
                                //can enhance the sense of depth and realism, especially
                                //when using multiple layers with varying levels of transparency.

                                //Using different values for the different layer of starfields
                                //can allow to avoid blurriness and achieve more depth,
                                //which will eventually lead to seamless scrolling background.

    // Update is called once per frame
    void Update()
    {
        // Get the MeshRenderer component attached to the game object
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();

        // Get the Material component of the MeshRenderer
        Material material = meshRenderer.material;

        // Get the current offset of the main texture of the material
        Vector2 offset = material.mainTextureOffset;

        // Calculate a new x and y offset based on the position and scale of the game object and the parallax factor
        offset.x = transform.position.x / transform.localScale.x / parallax;
        offset.y = transform.position.y / transform.localScale.y / parallax;

        // Set the new offset of the main texture of the material
        material.mainTextureOffset = offset;
    }
}
