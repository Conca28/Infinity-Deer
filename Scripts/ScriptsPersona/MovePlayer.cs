using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    public Rigidbody player;

    public Animator playerAnim;

    private Vector3 DirTeclas;

    private Vector3 AjusteFino;

    private Vector3 direcao;

    private bool Bater;

    public float moveSpeed;

    [SerializeField]
    private float VelX;

    [SerializeField]
     private float VelY;

    [SerializeField]
    private float VelZ;

    [SerializeField]
    private GameObject taco;
   
    void Start()
    {
        player = GetComponent<Rigidbody>();

        playerAnim = GetComponent<Animator>();

        taco.transform.localEulerAngles = new Vector3(-30, 0, 0);

        Bater = false;
    }

    void Update()
    {
      LeituraTeclado();
      LeituraTiro();
    }
    void LeituraTiro()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Bater == true)
        {
            taco.transform.localEulerAngles = new Vector3(-30, -50, 0);
        }
        else
        {
            taco.transform.localEulerAngles  = new Vector3(-30, 0, 0);
            Bater = false;
        }
    }
    
    void LeituraTeclado()
   {
        VelX = Input.GetAxis("Horizontal");
        VelZ = Input.GetAxis("Vertical");

        direcao = VelX * moveSpeed * transform.right + VelZ * moveSpeed * transform.forward;

        player.velocity = direcao;

        transform.localEulerAngles = new Vector3(0, PrimeiraPessoa.rotPlayX, 0);

   }
    
    public void TeclaVirtualRight()
    {
        player.velocity = new Vector3(moveSpeed, 0, 0);
    }

    public void TeclaVirtualLeft()
    {
        player.velocity = new Vector3(-moveSpeed, 0, 0);
    }

    public void TeclaVirtualUp()
    {
       player.velocity = new Vector3(0,0, moveSpeed);
    }

    public void TeclaVirtualDown()
    {
        player.velocity = new Vector3(0,0,-moveSpeed);
    }

    public void TeclaVirtualSpeed()
    {
        player.velocity = new Vector3(0,0, moveSpeed * 2);
    }

    public void SoltarTeclas()
    {
        player.velocity = new Vector3(0,0,0);
        Bater = false;
    }

    public void TeclaDisparo()
    {
        Bater = true;
    }

}



