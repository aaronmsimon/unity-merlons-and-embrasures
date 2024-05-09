using UnityEngine;

namespace MandE.Player
{
    [CreateAssetMenu(fileName = "New MouseWorld", menuName = "Scriptable Objects/Mouse World")]
    public class MouseWorld : ScriptableObject
    {
        [SerializeField] private LayerMask mousePlaneLayerMask;

        private Vector3 position;
        private bool hitMousePlane;

        public void UpdatePosition(Vector3 mousePosition)
        {
            // Set a ray from the screen to the mouse position
            Ray ray = Camera.main.ScreenPointToRay(mousePosition);
            // Shoot a raycast infinite distance until it hits the ground layer only
            hitMousePlane = Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, mousePlaneLayerMask);
            // Return the raycast point, which will be on the ground layer
            position = raycastHit.point;
        }

        public Vector3 Position
        {
            get
            {
                return this.position;
            }
        }

        public bool HitMousePlane
        {
            get
            {
                return this.hitMousePlane;
            }
        }
    }
}
