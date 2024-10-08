using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ServerLauncherGame : MonoBehaviourPunCallbacks
{

    public PhotonView player;

    public Transform spawn;

    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }


    public override void OnConnectedToMaster() //Conectarnos a una sala 
    {
        Debug.Log("Nos hemos conectado al master");
        PhotonNetwork.JoinRandomOrCreateRoom(); //Crear una sala si no existe
    }


    public override void OnJoinedRoom()
    {
        PhotonNetwork.Instantiate(player.name, spawn.position, spawn.rotation); //Spawn del player
    }


}
