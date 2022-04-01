using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [Header("Component")]
    Rigidbody2D rb;
    Animator anim;

    [Header("Stat")]
    [SerializeField]
    float moveSpeed;
    public int currenthealth;
    public int maxhealth;

    [Header("attack")]
    private float attacktime;
    [SerializeField] float timebetweenattack;


    public static PlayerControler instance;

    private void Awake() 
    {
        instance = this;
    }

    void Start()
    {
        currenthealth = maxhealth;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(Time.time >= attacktime)
            {
                anim.SetTrigger("attack");

                attacktime = Time.time + timebetweenattack;
            }
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move() 
    {
        if(Input.GetAxis("Horizontal") > 0.1 || Input.GetAxis("Horizontal") < -0.1 || Input.GetAxis("Vertical") > 0.1 || Input.GetAxis("Vertical") < -0.1)
        {
            anim.SetFloat("LastInputX", Input.GetAxis("Horizontal"));
            anim.SetFloat("LastInputY", Input.GetAxis("Vertical"));
        }

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(x,y) * moveSpeed * Time.fixedDeltaTime;

        rb.velocity.Normalize();

        if(x !=0 || y !=0)
        {
            anim.SetFloat("InputX", x);
            anim.SetFloat("InputY", y);
        }
        
    }

}
