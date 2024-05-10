using UnityEngine;

namespace MandE.Player
{
    [CreateAssetMenu(fileName = "New Mouse LayerMask", menuName = "Scriptable Objects/Mouse LayerMask")]
    public class MouseLayerMask : ScriptableObject
    {
        [SerializeField] private LayerMask layerMask;

        private Vector3 position;
        private bool hitLayerMask;

        public void UpdatePosition(Vector3 mousePosition)
        {
            // Set a ray from the screen to the mouse position
            Ray ray = Camera.main.ScreenPointToRay(mousePosition);
            // Shoot a raycast infinite distance until it hits the ground layer only
            hitLayerMask = Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, layerMask);
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

        public bool HitLayerMask
        {
            get
            {
                return this.hitLayerMask;
            }
        }
    }
}
