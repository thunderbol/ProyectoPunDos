using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Unity.VisualScripting;

public class ServerLauncherGame : MonoBehaviourPunCallbacks
{

    public PhotonView playerPref;

    public Transform spawn;

    // Start is called before the first frame update
    void Start()
    {
        // Ya no lo necesitamos - PhotonNetwork.ConnectUsingSettings();
        PhotonNetwork.JoinRandomOrCreateRoom(); //Solo es decirle que nos unamos a una sala
    }


    /* YA NO LO NECESITAMOS - ESTAMOS ACCEDIENDO A LA ESCENA DEL JUGADOR
    public override void OnConnectedToMaster() //Conectarnos a una sala 
    {
        Debug.Log("Nos hemos conectado al master");
        PhotonNetwork.JoinRandomOrCreateRoom(); //Crear una sala si no existe
    }
    */

    //Hay que agregar un texto 3D a nuestro player prefab

    public override void OnJoinedRoom()
    {
        GameObject player = PhotonNetwork.Instantiate(playerPref.name, spawn.position, spawn.rotation); //Spawn del player
        player.GetComponent<PhotonView>().RPC("SetNameText", RpcTarget.AllBuffered, PlayerPrefs.GetString("PlayerName"));

       
    }


}
