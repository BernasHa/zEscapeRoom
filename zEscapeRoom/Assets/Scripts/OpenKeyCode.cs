using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenKeyCode : MonoBehaviour
{
    public GameObject keyPad;
    public GameObject keyPadText;

    public bool inRange;

    // Start is called before the first frame update
    void Start()
    {
        inRange = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(inRange && Input.GetButtonDown("E"))
        {
            keyPad.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        inRange = true;
        keyPadText.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        inRange = false;
        keyPadText.SetActive(false);
    }
}
