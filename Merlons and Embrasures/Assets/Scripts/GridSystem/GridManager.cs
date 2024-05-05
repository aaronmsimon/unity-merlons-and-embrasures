using UnityEngine;
using CodeMonkey.Grid;

namespace MandE.Grid
{
    public class GridManager : MonoBehaviour
    {
        [SerializeField] private LevelGrid levelGrid;
        [SerializeField] private Transform cellPrefab;

        private void Awake()
        {
            levelGrid.GetGridSystem();
        }

        private void Start()
        {
            for (int x = 0; x < levelGrid.GridWidth; x++)
            {
                for (int z = 0; z < levelGrid.GridHeight; z++)
                {
                    GridPosition gridPosition = new GridPosition(x, z);
                    
                    Transform debugTransform = GameObject.Instantiate(cellPrefab, levelGrid.GetWorldPosition(gridPosition), Quaternion.identity);
                }
            }
        }
    }
}
