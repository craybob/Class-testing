using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mage : Player
{
    // Start is called before the first frame update
    [SerializeField] int hp = 50;
    SceneManager sceneManager;


    void Start()
    {
        base.speed = 4f;
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        base.speed = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        move();
        Jump();
    }

    public override void move()
    {
        base.speed = 2f;
        base.move();
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Danger")
        {
            hp--;
            SceneManager.LoadScene("SampleScene");
        }
    }
}
