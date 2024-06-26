using UnityEngine;
using CodeMonkey.Grid;

namespace MandE.Grid
{
    [CreateAssetMenu(fileName = "New LevelGrid", menuName = "Scriptable Objects/Level Grid")]
    public class LevelGrid : ScriptableObject
    {
        [SerializeField] private int gridWidth;
        [SerializeField] private int gridHeight;
        [SerializeField] private float cellSize;

        private GridSystem gridSystem;

        public GridSystem GetGridSystem()
        {
            if (gridSystem == null)
            {
                IntitializeGridSystem();
            }
            return gridSystem;
        }

        public void IntitializeGridSystem()
        {
            gridSystem = new GridSystem(gridWidth, gridHeight, cellSize);
        }
    }
}
