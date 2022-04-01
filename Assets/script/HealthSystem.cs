using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{

    public Sprite emptypoint, fullpoint;
    public Image life, life2, life3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(PlayerControler.instance.currenthealth)
        {
            case 0:
                life.sprite = emptypoint;
                life2.sprite = emptypoint;
                life3.sprite = emptypoint;
                break;
            case 1:
                life.sprite = fullpoint;
                life2.sprite = emptypoint;
                life3.sprite = emptypoint;
                break;
            case 2:
                life.sprite = fullpoint;
                life2.sprite = fullpoint;
                life3.sprite = emptypoint;
                break;
            case 3:
                life.sprite = fullpoint;
                life2.sprite = fullpoint;
                life3.sprite = fullpoint;
                break;
        }
    }
}
