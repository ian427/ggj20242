using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public GameObject Player;
    [SerializeField]
    private float MovementSpeed;
    
    private bool CanMove = false;
    private CircleCollider2D Field;
    [SerializeField]
    private float Range;
    private Transform target;
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision)
    {
       // Debug.Log("collided");
        if (collision.gameObject.tag == "Player")// checks for tag
        {
            //Debug.Log("collided player");
            CanMove = true;
        }
    }
    void Start()
    {// allows range enemis attack at to be adjusted

        Field = GetComponent<CircleCollider2D>();
        Field.radius = Range;
        Field.offset = (new Vector2(0.0f, 0.0f));

    }
    void Awake()
    {
       // Grab  values and place on the target.
        target = Player.transform;
        target.transform.position = new Vector3(0.8f, 0.0f, 0.8f);

    }

    void Update()
    {
        
        var step = MovementSpeed * Time.deltaTime; // calculate distance to move
        if (CanMove == true)
        {
          transform.position = Vector3.MoveTowards(transform.position, target.position, step);// Move our position a step closer to the target.
        }
        

    }
}
