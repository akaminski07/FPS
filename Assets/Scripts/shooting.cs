using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Camera cam;

    private RaycastHit hit;
    private Ray ray;
    private Game game;
    public AudioSource soundPlayer;
    public AudioSource gunShot;
    

    [Header("Unity Setup")]
    public ParticleSystem BOOM;
    // Start is called before the first frame update
    void Start()
    {
        game = GetComponent<Game>();
        if (game == null)
        {
            Debug.LogError("Game script not found on the same GameObject as shooting script.");
        }
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            gunShot.Play();
            ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag.Equals("NPC"))
                {
                    
                    enemy enemyHit = hit.collider.GetComponent<enemy>();
                    enemyHit.looseLife();
                    if (enemyHit.getLife() == 0)
                    {
                        soundPlayer.Play();
                        Debug.Log("You're gonna die!!!");
                        Instantiate(BOOM, hit.transform.position, Quaternion.identity);
                        game.DecreaseCapsuleNumber();
                        Destroy(hit.collider.gameObject);
                    }


                }
                if (hit.collider.tag.Equals("Wall"))
                {
                    Destroy(hit.collider.gameObject);
                    Instantiate(BOOM, hit.transform.position, Quaternion.identity);
                }

            }
        }

    }
    public void playSFX()
    {
        soundPlayer.Play();
    }

}
