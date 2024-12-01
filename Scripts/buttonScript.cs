using UnityEngine;

public class buttonScript : MonoBehaviour
{
    public GameObject blueEnvironment;
    public GameObject redEnvironment;
    public GameObject greenEnvironment;
    bool blueEnvironmentEnabled;
    bool redEnvironmentEnabled;
    bool greenEnvironmentEnabled;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        CheckBlue();
        CheckGreen();
        CheckRed();
    }
    void CheckBlue()
    {
        // Get all child objects with a Renderer component
        Renderer[] childRenderers = blueEnvironment.GetComponentsInChildren<Renderer>();

        // Loop through each Renderer 
        foreach (Renderer renderer in childRenderers)
        {
            if (blueEnvironmentEnabled==false){
                renderer.enabled = false;
            }
            else if (blueEnvironmentEnabled==true) { renderer.enabled = true; }
        }
    }
    void CheckRed()
    {
        // Get all child objects with a Renderer component
        Renderer[] childRenderers = redEnvironment.GetComponentsInChildren<Renderer>();

        // Loop through each Renderer and disable it
        foreach (Renderer renderer in childRenderers)
        {
            if (redEnvironmentEnabled == false)
            {
                renderer.enabled = false;
            }
            else if (redEnvironmentEnabled == true) { renderer.enabled = true; }
        }
    }
    void CheckGreen()
    {
        // Get all child objects with a Renderer component
        Renderer[] childRenderers = greenEnvironment.GetComponentsInChildren<Renderer>();

        // Loop through each Renderer and disable it
        foreach (Renderer renderer in childRenderers)
        {
            if (greenEnvironmentEnabled == false)
            {
                renderer.enabled = false;
            }
            else if (greenEnvironmentEnabled == true) { renderer.enabled = true; }
        }
    }
    public void EnableBlueEnvironment()
    {
        if(blueEnvironmentEnabled==true) { blueEnvironmentEnabled = false; }
        else if (blueEnvironmentEnabled!=true) { blueEnvironmentEnabled = true; }
    }
    public void EnableRedEnvironment()
    {
        if (redEnvironmentEnabled == true) { redEnvironmentEnabled = false; }
        else if (redEnvironmentEnabled != true) { redEnvironmentEnabled = true; }
    }
    public void EnableGreenEnvironment()
    {
        if (greenEnvironmentEnabled == true) { greenEnvironmentEnabled = false; }
        else if (greenEnvironmentEnabled != true) { greenEnvironmentEnabled = true; }
    }
}
