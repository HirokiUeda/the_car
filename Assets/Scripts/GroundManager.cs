using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision) {

        FindObjectOfType<GameManager>().GameEnd();

    }

}
