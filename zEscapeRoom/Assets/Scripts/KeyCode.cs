using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyCode : MonoBehaviour
{
    public GameObject player;
    public GameObject keyPad;
    public GameObject hud;
    public GameObject animatedDoor;
    public Animator anim;
    public Text textOB;
    public string correctInput = "1007";

    public AudioSource buttonPress;
    public AudioSource correctCode;
    public AudioSource wrongCode;

    private bool animated;

    // Start is called before the first frame update
    void Start()
    {
        keyPad.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (textOB.text == "Correct" && animated)
        {
            anim.SetBool("Open", true);
            CorrectCode();
        }

        if (keyPad.activeInHierarchy)
        {
            hud.SetActive(false);
            player.GetComponent<PlayerMovement>().enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void Exit()
    {
        keyPad.SetActive(false);
        hud.SetActive(true);
        player.GetComponent<PlayerMovement>().enabled = true;
        player.GetComponent<LookingController>().enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Number(int number)
    {
        textOB.text += number.ToString();
        buttonPress.Play();
    }
    public void Clear()
    {
        textOB.text = "";
        buttonPress.Play();
    }

    public void CorrectCode()
    {
        if (textOB.text == correctInput)
        {
            textOB.text = "Correct";
            correctCode.Play();
            anim.SetBool("Open", true);
        }
        else
        {
            textOB.text = "ERROR";
            wrongCode.Play();
            textOB.text = "";
        }
    }


}
