using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FInishScript : MonoBehaviour
{
    [SerializeField] Canvas FinishScreen;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameObject Screen = FinishScreen.transform.gameObject;
            bool isActive = Screen.activeSelf;
            Screen.SetActive(!isActive);
            Debug.Log("Collided");
        }
    }
}
