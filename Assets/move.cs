using UnityEngine;
using UnityEngine.SceneManagement; 

public class AirTrickController : MonoBehaviour
{
    public float moveSpeed = 5f; 
    public float jumpForce = 5f; 
    public float rotateSpeed = 20000f; 
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // การเคลื่อนที่
        float moveX = 0f;
        float moveZ = 0f;

        if (Input.GetKey(KeyCode.A)) 
        {
            moveX = -1f;
        }
        if (Input.GetKey(KeyCode.D)) 
        {
            moveX = 1f;
        }
        if (Input.GetKey(KeyCode.W)) 
        {
            moveZ = 1f;
        }
        if (Input.GetKey(KeyCode.S)) 
        {
            moveZ = -1f;
        }

        Vector3 move = new Vector3(moveX, 0f, moveZ) * moveSpeed * Time.deltaTime;
        transform.Translate(move);

        
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        
        if (Input.GetKey(KeyCode.Q)) 
        {
            transform.Rotate(Vector3.up * -rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E)) 
        {
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        }

        
        if (Input.GetKeyDown(KeyCode.R))
        {
            RecoverUpright();
        }

        
        if (Input.GetKeyDown(KeyCode.P))
        {
            ResetGame();
        }
    }

    
    private void RecoverUpright()
    {
        
        rb.velocity  = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        
        transform.rotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y, 0f);
    }

    
    private void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // โหลดฉากปัจจุบันใหม่
    }
}