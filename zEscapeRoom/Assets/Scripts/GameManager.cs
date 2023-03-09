using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject levelWonUI;
    public void GoalReached()
    {
        levelWonUI.SetActive(true);
    }
}
