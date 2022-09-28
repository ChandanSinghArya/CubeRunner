using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float movementSpeed = 1f;
    public float PlayerSpeed = 200f;
    public float MaxX;
    public float MinX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(movementSpeed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))  
        {
            transform.position = transform.position + new Vector3(-movementSpeed * Time.deltaTime, 0, 0);
        }
        //For clamping
        Vector3 PlayerPos = transform.position;
        if (PlayerPos.x>MaxX)
        {
            PlayerPos.x = MaxX; 
        }
        else if (PlayerPos.x<MinX)
        {
            PlayerPos.x = MinX;
        }
        transform.position = PlayerPos;
        
    }
    private void FixedUpdate()
    {
        rigidBody.AddForce(0, 0, PlayerSpeed * Time.deltaTime);
    }
}
