using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public AudioClip boom;
   
    void OnCollisionEnter(Collision collisionInfo)
     {
         if(collisionInfo.collider.tag=="Obstacle")
         {
            movement.enabled = false;
            AudioSource.PlayClipAtPoint(boom, transform.position,999);
            FindObjectOfType<GameManager>().EndGame();
        }
     }

}
