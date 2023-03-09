using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeathScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Die();
        }
    }

    void Die()
    {
        GetComponent<PlayerMovement>().enabled = false;
        GetComponent<LookingController>().enabled = false;
        Invoke(nameof(Respawn), 2f);
        Respawn();
        Debug.Log("Death");
    }

    void Respawn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
