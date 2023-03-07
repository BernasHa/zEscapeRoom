using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public Animator door;
    public GameObject openCloseText;
    public AudioSource doorSound;

    private bool inRange;

    // Start is called before the first frame update
    void Start()
    {
        inRange = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "InRange")
        {
            inRange = true;
            openCloseText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "InRange")
        {
            inRange = false;
            openCloseText.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(inRange && Input.GetButtonDown("E"))
        {
            DoorOpen();
        }
        else
        {
            DoorClose();
        }
    }

    void DoorOpen()
    {
        Debug.Log("Opened");
        door.SetBool("Open", true);
        door.SetBool("Close", false);
        doorSound.Play();
    }

    void DoorClose()
    {
        Debug.Log("Closed");
        door.SetBool("Open", false);
        door.SetBool("Close", true);
    }
}
