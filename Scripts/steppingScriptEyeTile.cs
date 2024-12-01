using UnityEngine;

public class steppingScriptEyeTile : MonoBehaviour
{
    [SerializeField] private ParticleSystem effect;
    bool hasTriggered = false;
    string childName = "Button particle system";

    private void Start()
    {
        // Find the child by name
        Transform childTransform = transform.Find(childName);

        if (childTransform != null)
        {
            // Assign the child GameObject
            effect = childTransform.GetComponent<ParticleSystem>();
        }
        else { Debug.Log("No particle system found lol"); }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!hasTriggered && collision.CompareTag("Player"))
        {
            hasTriggered = true;
            if (effect!=null)
            {
                ParticleSystem newEffect=Instantiate(effect, transform.position, transform.rotation);
                newEffect.Play();
            }
            pressedState();
        }
    }
    void pressedState ()
    {
        string hexcolor = "#9C9C9C";
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (ColorUtility.TryParseHtmlString(hexcolor, out Color newcolor))
        {
            sprite.color = newcolor; // Apply the color to the sprite
        }
        transform.localScale = new Vector2(0.9f, 0.9f);
    }
}
