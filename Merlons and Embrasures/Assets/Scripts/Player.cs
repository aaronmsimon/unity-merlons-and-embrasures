using UnityEngine;

public class Player : MonoBehaviour
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

    private void Update()
    {
        // Debug.Log(playerControls.Gameplay.MousePosition.ReadValue<Vector2>());
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }
}
