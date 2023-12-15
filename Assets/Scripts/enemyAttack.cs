using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class enemyAttack : MonoBehaviour
{
    private enemy enemyMovement;
    private Transform player;
    public float attackRange = 100f;


    public Material defaultMaterial;
    public Material allertMaterial;
    private Renderer rend;

    private bool foundPlayer;

    // Start is called before the first frame update

    private void Awake()
    {
        //enemyScript = GetComponent<enemy>();

        player = GameObject.FindGameObjectWithTag("Player").transform;
        enemyMovement = GetComponent<enemy>();
        rend = GetComponent<Renderer>();
    

}
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) <= attackRange)
        {
            rend.sharedMaterial = allertMaterial;
            enemyMovement.badGuy.SetDestination(player.position);
            foundPlayer = true;
        }

        else if(foundPlayer)
        {
            rend.sharedMaterial = defaultMaterial;
            enemyMovement.newLocation();
            foundPlayer = false;
        }
    }
}
