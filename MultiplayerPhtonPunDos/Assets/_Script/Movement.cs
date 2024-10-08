using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Movement : MonoBehaviourPunCallbacks
{

    public float velplayer = 5;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //comprobación de si pun identifica cual es el jugador instanciado
        if (photonView.IsMine)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 displacement = new Vector3(moveHorizontal, 0, moveVertical) * velplayer * Time.deltaTime; //Time.deltatime, para que no se pase de los frames que pueda manejar el update
            
            transform.Translate(displacement);
        }
    }
}
