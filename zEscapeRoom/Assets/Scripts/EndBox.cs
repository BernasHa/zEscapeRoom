using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndBox : MonoBehaviour
{
    public GameObject levelWonUI;

    private void OnTriggerEnter(Collider other)
    {
        levelWonUI.SetActive(true);
    }
}
