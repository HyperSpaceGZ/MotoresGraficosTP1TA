using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody Ballrb;
    public GameObject Coin;
    
    // Start is called before the first frame update
    void Start()
    {
        Ballrb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
