using UnityEngine;
using CodeMonkey.Grid;

namespace MandE.Buildings
{
    public class Building : MonoBehaviour
    {
        [SerializeField] private BuildingsRuntimeSet runtimeSet;
        
        private GridPosition gridPosition;

        private void OnEnable()
        {
            runtimeSet.Add(this);
        }

        private void OnDisable()
        {
            runtimeSet.Remove(this);
        }
    }
}
