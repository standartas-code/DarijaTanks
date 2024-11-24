using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    // public Text winner_text;

    public Transform healthBar;
    public int maxHealth = 100;

    private int health;

    void Start()
    {
        health = maxHealth;
    }

    private void Update()
    {
        if(health == 0) loadScene();
        string winner = " ";
        if (gameObject.name == "yellow")
        {
            winner = "red";
        }
        else
        {
            winner = "yellow";
        }
        //UpdateText(winner);

    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        health = Mathf.Max(health, 0);
        health = Mathf.Min(health, maxHealth);

        healthBar.localScale = new Vector3((float)health / maxHealth, 1, 1);
    }



    public void loadScene()
    {
        SceneManager.LoadScene("end");
    }
    //public void UpdateText(string text)
    //{
    //    winner_text.text = text;
    //}

}
