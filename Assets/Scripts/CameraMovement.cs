using System.Collections;
using System.Collections.Generic;
using UnityEditor.Networking.PlayerConnection;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    GameObject player;
    PlayerMovement playerMovement;
    public float cameraDistance = 10f;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerMovement = FindObjectOfType<PlayerMovement>();
    }
    void Update()
    {
        if(playerMovement.rb.transform.position.y > playerMovement.LOWERBORDER) transform.position = new Vector3(player.transform.position.x + cameraDistance, transform.position.y, transform.position.z);
    }
}
