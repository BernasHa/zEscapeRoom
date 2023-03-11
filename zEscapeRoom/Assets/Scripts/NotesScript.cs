using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesScript : MonoBehaviour
{
    public GameObject player;
    public GameObject hintUI;
    public GameObject readText;
    public bool inRange;

    // Start is called before the first frame update
    void Start()
    {
        hintUI.SetActive(false);
        readText.SetActive(false);
        inRange = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("E") && inRange)
        {
            hintUI.SetActive(true);
            player.GetComponent<PlayerMovement>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "inRange")
        {
            inRange = true;
            readText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "inRange")
        {
            inRange = false;
            readText.SetActive(false);
        }
    }

    public void CloseNote()
    {
        hintUI.SetActive(false);
        player.GetComponent<PlayerMovement>().enabled = true;
    }
}
