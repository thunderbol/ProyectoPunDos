using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class PlayerName : MonoBehaviourPunCallbacks
{
    public TMP_Text playerName;

    [PunRPC]
    public void SetNameText(string name) 
    {
        playerName.text = name;
    }


    /*
     Asignamos a nuestro player este script 
    y agregamo el Texto a la variable

    Vamos a nuestro MenuManager para guardar el nombre en un playerpref
     */


    /*
    [PunRPC]

    En Unity, el atributo [PunRPC] es parte del sistema de red de Photon Unity Networking (PUN), que permite la creación de juegos multijugador. Este atributo se usa para llamar a métodos de forma remota, es decir, desde una máquina (cliente o servidor) a otra máquina dentro de una misma partida de red. Aquí te explico cómo funciona y para qué sirve:

¿Qué es [PunRPC]?
[PunRPC] es un atributo que se coloca sobre un método para indicarle a Photon que ese método puede ser invocado por otros jugadores en la red. Cuando un cliente quiere ejecutar un método en otro cliente o en el servidor, puede hacer uso de la función PhotonView.RPC().

¿Para qué sirve?
Sirve para permitir la sincronización de acciones o eventos entre diferentes jugadores en una partida multijugador. Puedes usarlo para cosas como:

Actualizar el estado del juego en todas las máquinas (por ejemplo, cuando un jugador recoge un objeto y necesitas que todos los jugadores lo vean).
Enviar datos específicos entre los jugadores (como posiciones, vidas, o información del personaje).
Ejecutar acciones concretas en todos los jugadores o en uno específico (como realizar ataques o disparos en un juego de combate).

    */
}
