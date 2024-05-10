using UnityEngine;
using CodeMonkey.Grid;
using MandE.Grid;
using UnityEngine.InputSystem;
using MandE.Game;

namespace MandE.Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private MouseLayerMask mouseBuildable;
        [SerializeField] private LevelGrid levelGrid;
        [SerializeField] private ActiveInventory buildingActiveInventory;

        private PlayerControls playerControls;

        private void Awake()
        {
            playerControls = new PlayerControls();
        }

        private void OnEnable()
        {
            playerControls.Enable();

            playerControls.Gameplay.MouseClick.performed += OnMouseClick;
        }

        private void Update()
        {
            UpdateMousePosition();

        }

        private void OnDisable()
        {
            playerControls.Disable();

            playerControls.Gameplay.MouseClick.performed -= OnMouseClick;
        }

        private void UpdateMousePosition()
        {
            Vector2 mousePosition = playerControls.Gameplay.MousePosition.ReadValue<Vector2>();

            mouseBuildable.UpdatePosition(mousePosition);
        }

        private void OnMouseClick(InputAction.CallbackContext context)
        {
            if (context.performed && mouseBuildable.HitLayerMask && !mouseBuildable.IsOverUI)
            {
                AddBuilding();
            }
        }

        private void AddBuilding()
        {
            if (buildingActiveInventory.CurrentActive.ItemCount > 0)
            {
                GridPosition gridPosition = levelGrid.GetGridSystem().GetGridPosition(mouseBuildable.Position);
                Vector3 worldPosition = levelGrid.GetGridSystem().GetWorldPosition(gridPosition);

                Instantiate(buildingActiveInventory.CurrentActive.Prefab, worldPosition, Quaternion.identity);

                buildingActiveInventory.CurrentActive.ChangeItemCount(-1);
            }
        }
    }
}
