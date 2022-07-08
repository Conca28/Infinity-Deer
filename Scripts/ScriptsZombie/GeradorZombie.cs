using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorZombie : MonoBehaviour
{
    public GameObject[] zombie; 

   int random;

   public float time;

   public float delay;
    
    void Start()
    {
        InvokeRepeating("RepeatingZombie", time, delay);
    }

    
    void Update()
    {
        
    }

    void RepeatingZombie()
    {
        random = Random.Range(0,zombie.Length);
        Instantiate(zombie[random], transform.position, transform.rotation);
        zombie[0].SetActive(true);
        zombie[1].SetActive(true);
        zombie[2].SetActive(true);
        zombie[3].SetActive(true);
        zombie[4].SetActive(true);    
    }
}
