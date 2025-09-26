using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerControls playerControls;

    private void Awake()
    {
        playerControls = new PlayerControls();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        Jump();
    }

    public void Jump()
    {
        if (playerControls.Ground.Jump.triggered)
        {
            print("player has jumped");
        }
    }

}
