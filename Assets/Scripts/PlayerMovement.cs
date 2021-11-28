using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Dieses Script beschreibt das Spielermovement.

public class PlayerMovement : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }
    }
}
