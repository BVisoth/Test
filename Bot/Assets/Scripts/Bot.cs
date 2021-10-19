using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    private Rigidbody2D rb;
    private float velocity;
    public GameObject player;
    [SerializeField] float moveSpeed = 15f;
    [SerializeField] float screenWidthInUnits = 10f;
    [SerializeField] public bool followX = false;
    [SerializeField] public bool followY = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = FindObjectOfType(typeof(Player)) as GameObject;
        
      
    }



    void Update()
    {
        MoveBot();
    }

    void MoveBot()
    {
        Vector2 moveDir = player.transform.position;
        //Vector2 mousePosInUnits = Camera.main.ScreenToWorldPoint(position: player.transform.position); // Screen.width * screenWidthInUnits; 

        if (!followX)
        {
            //mousePosInUnits.x = transform.position.x;
            moveDir.x = transform.position.x;

        }
        if (!followY)
        {
            //mousePosInUnits.y = transform.position.y;
            moveDir.y = transform.position.y;

        }
        var movementThisFrame = moveSpeed * Time.deltaTime;
        transform.position = Vector2.MoveTowards
            (transform.position, moveDir, movementThisFrame);
    }
}
