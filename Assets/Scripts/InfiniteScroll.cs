using UnityEngine;
using System.Collections;

public class InfiniteScroll : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Get the MeshRenderer component attached to the game object
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();

        // Get the Material component of the MeshRenderer
        Material material = meshRenderer.material;

        // Get the current offset of the main texture of the material
        Vector2 offset = material.mainTextureOffset;

        // Increment the y (or whatever axis you'd like) offset of the texture over time to create a scrolling effect
        offset.y += Time.deltaTime / 10f;

        // Set the new offset of the main texture of the material
        material.mainTextureOffset = offset;
    }
}
