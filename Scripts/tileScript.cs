using UnityEngine;

public class tileScript : MonoBehaviour
{
    public GameObject player;
    bool on;

    private void Start()
    {

    }
    private void Update()
    {
        if (on) { GetComponent<SpriteRenderer>().color = new Color32(240, 24, 63, 255); }
        else if (!on) { GetComponent<SpriteRenderer>().material.color = new Color32(36, 240, 24, 255); }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Player")
        {
            on = !on;
            Debug.Log("Color changed to " + GetComponent<Renderer>().material.color);
        }
    }


} 
