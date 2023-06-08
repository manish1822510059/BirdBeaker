using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerSpawner : MonoBehaviour
{
   public GameObject[] playerPrefabs;

   public Transform[] spawnPoints;

   private void Start(){
    int randomNumber  = Random.Range(0,spawnPoints.Length);
    Transform spawnPoint = spawnPoints[randomNumber];
    GameObject playerToSpawn  = playerPrefabs[(int)PhotonNetwork.LocalPlayer.CustomProperties["playerAvatar"]];
    
    GameObject instantiatedObject = PhotonNetwork.Instantiate(playerToSpawn.name,spawnPoint.position,Quaternion.identity);
    
    // Transform tran = GameObject.Find("MainCamera").GetComponent<CameraFollow>().player;
    //    tran = playerToSpawn.GetComponent<Transform>();
    CameraFollow cf = GameObject.Find("MainCamera").GetComponent<CameraFollow>();
    cf.setPlayer(instantiatedObject);
 
   }


    public void DoExitGame() {
     Application.Quit();
 }
}
