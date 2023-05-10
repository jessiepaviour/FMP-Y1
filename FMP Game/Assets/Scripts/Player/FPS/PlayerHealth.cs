using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    private float health;
    private float lerpTimer;
    public float maxHealth = 100;
    public float chipSpeed = 2f;
    public Image frontHealthbar;
    public Image backHealthbar;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        health = Mathf.Clamp(health, 0, maxHealth);
        UpdateHealthUI();
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            TakeDamage(Random.Range(5, 10));
        }
    }
    public void UpdateHealthUI()
    {
        Debug.Log(health);
        float fillF = frontHealthbar.fillAmount;
        float fillB = backHealthbar.fillAmount;
        float hFraction = health / maxHealth;
        if (fillB > hFraction)
        {
            frontHealthbar.fillAmount = hFraction;
            backHealthbar.color = Color.red;
            lerpTimer += Time.deltaTime;
            float percentComplete = lerpTimer / chipSpeed;
            backHealthbar.fillAmount = Mathf.Lerp(fillB,hFraction,percentComplete);
        }
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
        lerpTimer = 0f;
    }
}
