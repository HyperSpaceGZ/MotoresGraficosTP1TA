using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;
    public Text WinText;
    public Text Score;
    public int CoinsTotal;
    public int CoinsCollected;

    // Start is called before the first frame update
    void Start()
    {
        CoinsTotal = GameObject.FindGameObjectsWithTag("Coin").Length;
        WinText.enabled = false;
        UpdateUI();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            CoinsCollected++;
            UpdateUI();

            if (CoinsCollected == CoinsTotal)
            {

                Debug.Log("You Win!");
                WinText.enabled = true;
            }
        }
    }

    private void UpdateUI()
    {
        Score.text = CoinsCollected.ToString() + " / " + CoinsTotal.ToString();
    }


    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal")*Speed*Time.deltaTime;
        float verticalInput = Input.GetAxis("Vertical")*Speed*Time.deltaTime;

        transform.Translate(horizontalInput, 0f, verticalInput);

        /*
           Input.GetAxis("Vertical");

           if(Input.GetKey(KeyCode.D))
           {
               transform.Translate(Speed * Time.deltaTime, 0f, 0f);
           }

           if (Input.GetKey(KeyCode.A))
           {
               transform.Translate(-Speed * Time.deltaTime, 0f, 0f);
           }

           if (Input.GetKey(KeyCode.W))
           {
               transform.Translate(0f, 0f, Speed * Time.deltaTime);
           }

           if (Input.GetKey(KeyCode.S))
           {
               transform.Translate(0f, 0f, -Speed * Time.deltaTime);
           }

        */


    }
}

