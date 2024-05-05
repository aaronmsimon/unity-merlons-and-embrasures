using UnityEngine;

namespace MandE.Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private MouseWorld mouseWorld;

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
            UpdateMousePosition();
        }

        private void OnDisable()
        {
            playerControls.Disable();
        }

        private void UpdateMousePosition()
        {
            Vector2 mousePosition = playerControls.Gameplay.MousePosition.ReadValue<Vector2>();

            mouseWorld.UpdatePosition(mousePosition);
        }
    }
}
