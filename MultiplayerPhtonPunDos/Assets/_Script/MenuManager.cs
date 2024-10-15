using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviourPunCallbacks
{
    public TMP_InputField nameInput;

    public TMP_Text button;

    //Debemos verificar si hay un bottón de conección
    public void OnclickConnect() 
    {
        //debemos hacer comprobración si si se ha introducido un nombre
        if (nameInput.text.Length >= 1) 
        {
            PhotonNetwork.NickName = nameInput.text;

            //Guardamos en un player Pref el nombre del jugador despues de abrer creado el script de playername
            PlayerPrefs.SetString("PlayerName", nameInput.text); //Debemos actualizar en SeverLauncherGame.cs para cambiar el nuevo nombre del nuevo usuario

            button.text = "Conectando al server ...";
            PhotonNetwork.ConnectUsingSettings();
        }
        
    }

    //Conection to server
    public override void OnConnectedToMaster() //Conectarnos a una sala 
    {
        SceneManager.LoadScene("GameMultiplayer");

        //Debemos ir al serverLauncher y hacer cambios en el start
    }

}
