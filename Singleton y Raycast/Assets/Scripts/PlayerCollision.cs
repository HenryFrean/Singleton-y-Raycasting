using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private MovementPlayer playerMove;

    private void Start()
    {
        playerMove = GetComponent<MovementPlayer>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Gold"))
        {
            Destroy(other.gameObject);

            GameManager.Score++;

            Debug.Log(GameManager.Score);
        }
    }
}
