using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int MaxHealth;
    private int currentHealth;

    private Vector3 InitialPosition;

    public Text healthText;

    private void Start()
    {
        InitialPosition = transform.position;
        currentHealth = MaxHealth;

        if (healthText != null)
        {
            healthText.text = currentHealth.ToString();
        }
    }

    public void TakeDamage(int damageTaken)
    {
        currentHealth -= damageTaken;

        if (healthText != null)
        {
            healthText.text = currentHealth.ToString();
        }

        if (currentHealth <= 0)
        {
            //Debug.Log("estoy muerto");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //transform.position = InitialPosition;
            //currentHealth = MaxHealth;
            //healthText.text = currentHealth.ToString();
            Die();
        }
    }

    public virtual void Die()
    {
    }
}