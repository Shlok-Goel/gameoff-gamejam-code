using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausingScreenScript : MonoBehaviour
{
    [SerializeField] Canvas pauseMenu;
    [SerializeField] GameObject player;
    // Update is called once per frame
    private void Start()
    {

    }
    void Update()
    {
        GameObject pauseScreen = pauseMenu.transform.gameObject;
        bool isActive = pauseScreen.activeSelf;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseScreen.SetActive(!isActive);
            GamePaused();
        }
    }
    void GamePaused()
    {
        playerMovement playerMoveScript = player.GetComponent<playerMovement>();
        bool isActive = playerMoveScript.transform.gameObject.activeSelf;
        isActive = !isActive;
        Debug.Log("Game Paused");
    }
}
