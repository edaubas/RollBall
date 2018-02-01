using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_cont : MonoBehaviour {

    public float speed;
    public Text textCount;
    public Text textWin;

    private Rigidbody rb;
    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        setCountText();
        textWin.text = "";
    }
   	
	void FixedUpdate () {
        float hMovement = Input.GetAxis("Horizontal");
        float vMovement = Input.GetAxis("Vertical");

        //JUMP!!
        Vector3 movement = new Vector3(hMovement * speed, 0.0f, vMovement * speed);
        if (Input.GetKeyDown(KeyCode.Space) & transform.position.y == 0.5f)
        {
            movement = new Vector3(hMovement * speed, 300.0f, vMovement * speed);
        }
        else
        {
            movement = new Vector3(hMovement * speed, 0.0f, vMovement * speed);
        };
        rb.AddForce(movement);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up")) {

            other.gameObject.SetActive(false);
            count++;
            setCountText();
        }
    }

    void setCountText()
    {
        textCount.text = "Score: " + count.ToString();
        if (count == 6)
        {
            textWin.text = "WIN!!!";
        }

    }
}
