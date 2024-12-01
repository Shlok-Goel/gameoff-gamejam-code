using UnityEngine;

public class eyeTileScript : MonoBehaviour
{
    public GameObject wall;
   

    private void Start()
    {
        // Get all child objects with a Renderer component
        Renderer[] childRenderers = wall.GetComponentsInChildren<Renderer>();

        // Loop through each Renderer and enable it
        foreach (Renderer renderer in childRenderers)
        {
            renderer.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ShowWalls();
        }
        Debug.Log("Collided with button");
        
    }
    void ShowWalls()
    {
        // Get all child objects with a Renderer component
        Renderer[] childRenderers = wall.GetComponentsInChildren<Renderer>();

        // Loop through each Renderer and enable it
        foreach (Renderer renderer in childRenderers)
        {
            renderer.enabled = true;
        }

    }
}
