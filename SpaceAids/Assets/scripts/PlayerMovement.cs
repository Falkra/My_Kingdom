using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public KeyCode jumpKey;
    public KeyCode moveLeftKey;
    public KeyCode moveRightKey;


    public int jumpHeight = 13;
    public bool _isonground = true;

    private Rigidbody2D _rigidBody;
    // Use this for initialization
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(jumpKey) && _isonground)
        {
            _rigidBody.AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
            _isonground = false;
        }

        if (Input.GetKey(moveLeftKey))
        {
            transform.Translate (-10f * Time.deltaTime, 0f, 0f );
        }

        if (Input.GetKey(moveRightKey))
        {
            transform.Translate (10f * Time.deltaTime, 0f, 0f);
        }
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            _isonground = true;

        }
    }
}
