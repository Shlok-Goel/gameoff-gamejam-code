using UnityEngine;

public class FakeWallButtonScript : MonoBehaviour
{

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            OnButtonPressed();
        }
    }
    
    void OnButtonPressed()
    {
        Transform connectedWall = gameObject.transform.GetChild(0);

        if (connectedWall!=null)
        {
            Destroy(connectedWall.gameObject);
        }
        Debug.Log("Button Pressed");
    }
}
