using UnityEngine;
using CodeMonkey.Grid;
using MandE.Grid;
using UnityEngine.InputSystem;
using MandE.Game;

namespace MandE.Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private MouseWorld mouseWorld;
        [SerializeField] private LevelGrid levelGrid;
        [SerializeField] private Inventory building1x1Inventory;

        private PlayerControls playerControls;

        private void Awake()
        {
            playerControls = new PlayerControls();
        }

        private void OnEnable()
        {
            playerControls.Enable();

            playerControls.Gameplay.MouseClick.performed += AddBuilding;
        }

        private void Update()
        {
            UpdateMousePosition();

        }

        private void OnDisable()
        {
            playerControls.Disable();

            playerControls.Gameplay.MouseClick.performed -= AddBuilding;
        }

        private void UpdateMousePosition()
        {
            Vector2 mousePosition = playerControls.Gameplay.MousePosition.ReadValue<Vector2>();

            mouseWorld.UpdatePosition(mousePosition);
        }

        public void AddBuilding(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                if (building1x1Inventory.ItemCount > 0)
                {
                    GridPosition gridPosition = levelGrid.GetGridSystem().GetGridPosition(mouseWorld.Position);
                    Vector3 worldPosition = levelGrid.GetGridSystem().GetWorldPosition(gridPosition);

                    Instantiate(building1x1Inventory.Prefab, worldPosition, Quaternion.identity);

                    building1x1Inventory.ChangeItemCount(-1);
                }
            }
        }
    }
}
