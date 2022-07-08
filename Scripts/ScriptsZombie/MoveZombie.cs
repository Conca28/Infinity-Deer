using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveZombie : MonoBehaviour
{
    public NavMeshAgent zombie;

    public Transform player;

    public GameObject tiro;

    private float velocidade = 2f;

    public static float vidaZombie = 30;


    void Start()
    {
        zombie = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Personagens").transform;
    }

    
    void Update()
    {
      zombie.SetDestination(player.position);
    }

    private void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.CompareTag("Taco"))
      {
        vidaZombie -= 10;
        Destroy(tiro);
      }

      if(other.gameObject.CompareTag("Player"))
      {
        vidaZombie -= 10;
        Destroy(tiro);
      }
    } 

}
