using UnityEngine;

public class CameraFollow : MonoBehaviour 
{
    public Transform player; // this will create a reference on your unity editor "named - player"
    public Vectoe3 offset;  // this will set the camera where ever we want. If you set offset to 0,0,0 it will become a fps game.


 void Update() // this checks the current position of the player once every frame.
 {
   transform.position = player.position = offset; // this tells the camera to follow player + offset.

} 
