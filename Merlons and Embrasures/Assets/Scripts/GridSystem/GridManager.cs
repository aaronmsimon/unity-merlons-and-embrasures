using UnityEngine;
using CodeMonkey.Grid;

namespace MandE.Grid
{
    public class GridManager : MonoBehaviour
    {
        [SerializeField] private LevelGrid levelGrid;
        [SerializeField] private Transform cellPrefab;
        [SerializeField] private Transform gridParent;

        private GridSystem gridSystem;

        private void Awake()
        {
            gridSystem = levelGrid.GetGridSystem();
        }

        private void Start()
        {
            for (int x = 0; x < gridSystem.Width; x++)
            {
                for (int z = 0; z < gridSystem.Height; z++)
                {
                    GridPosition gridPosition = new GridPosition(x, z);
                    Transform cell = Instantiate(cellPrefab, gridSystem.GetWorldPosition(gridPosition), Quaternion.identity);
                    cell.parent = gridParent;
                }
            }
        }
    }
}
