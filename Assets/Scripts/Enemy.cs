using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float speed = 4.5f;
    private int directionX = 1;
    private Rigidbody2D rigidBody;
    public bool isAlive = true;
    public SpriteRenderer renderer;
    float dirx;
    private SFXManager sfxManager;
    private BGMManager bgmManager;

    // Start is called before the first frame update
    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
        bgmManager = GameObject.Find("BGMManager").GetComponent<BGMManager>();
    }

     void FixedUpdate()
    {
        if(isAlive)
        {
             //Añade velocidad en el eje X y deja el eje Y sin tocar por codigo.
        rigidBody.velocity = new Vector2(directionX * speed, rigidBody.velocity.y);
        }
        else
        {
            rigidBody.velocity = Vector2.zero;
        }

    }

        private void OnCollisionEnter2D(Collision2D hit)
    {
        
        if(hit.gameObject.tag == "Pared" || hit.gameObject.tag == "Enemy" || hit.gameObject.tag == "Caida")
        {
            Debug.Log("me he chocado");
            
            if(directionX == 1)
            {
                directionX = -1;
                renderer.flipX = true;
            }
            else
            {
                directionX = 1;
                renderer.flipX = false;
            }

        }
        else if(hit.gameObject.tag == "MuereRock")
        {
            Destroy(hit.gameObject);
            sfxManager.DeathSound();
            bgmManager.StopBGM();
            SceneManager.LoadScene("Dead");

           
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}
