using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocity = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        var player = Player.Create(horizontal, 0, vertical, velocity);
        
        transform.Translate(player.Movement);

        GetComponent<Animator>().SetBool("isMoving", player.IsMoving());
    }
}
