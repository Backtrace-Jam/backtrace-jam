using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    public float health;
    public Slider slider;

    void Update()
    {
        slider.value = health;
    }

     void OnCollisionEnter(Collision obj)
    {
        if(obj.gameObject.tag == "Enemy")
            health = health-10f;
            HealthLoss();

    }
    
    void HealthLoss()
    {
        if (health == 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
