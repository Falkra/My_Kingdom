using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour {

    public bool playerIsInHitbox = false;
    public bool isPlayer1 = true;
    public Text HealthDisplay;
    public int maxHP;

    public int damegeIndicator = 5;
    public int hitPoints;

    public KeyCode hit;

	// Use this for initialization
	void Start () {
        HealthDisplay.text = hitPoints + "/" + maxHP;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(hit) && playerIsInHitbox)
        {
            hitPoints = hitPoints - damegeIndicator;
            HealthDisplay.text = hitPoints + "/" + maxHP + "HP";
            
            
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "P1" && !isPlayer1)
        {
            playerIsInHitbox = true;
        }

        if (other.tag == "P2" && isPlayer1)
        {
            playerIsInHitbox = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "P1" && !isPlayer1)
        {
            playerIsInHitbox = false;
        }

        if (other.tag == "P2" && isPlayer1)
        {
            playerIsInHitbox = false;
        }
    }
}
