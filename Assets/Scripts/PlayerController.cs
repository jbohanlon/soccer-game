using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    private float xInput;
    private float yInput;

    private Rigidbody rb;

    public int coinsCollected;
    private int totalCoins = 10;

    [SerializeField] public TextMeshProUGUI winText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

        // Reset the level if the ball falls off the platform
        if (transform.position.y <= -5f)
        {
            SceneManager.LoadScene(0);
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(xInput * moveSpeed, 0, yInput * moveSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            coinsCollected++;
            winText.text = $"You win!\nYou got {coinsCollected}\n out of {totalCoins} coins!";
            other.gameObject.SetActive(false);
        }
    }
}
