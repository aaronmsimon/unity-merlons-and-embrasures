using UnityEngine;
using CodeMonkey.Grid;
using MandE.Player;
using System.Runtime.CompilerServices;

namespace MandE.Grid
{
    public class GridManager : MonoBehaviour
    {
        [SerializeField] private LevelGrid levelGrid;
        [SerializeField] private Transform cellPrefab;
        [SerializeField] private MouseWorld mouseWorld;

        [SerializeField] private Transform building;

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
                    
                    gridSystem.GetGridObject(gridPosition).CellTransform = Instantiate(cellPrefab, gridSystem.GetWorldPosition(gridPosition), Quaternion.identity);
                }
            }
        }

        private void Update()
        {
            GridPosition gridPosition = gridSystem.GetGridPosition(mouseWorld.Position);
            Vector3 worldPosition = gridSystem.GetWorldPosition(gridPosition);
            building.position = worldPosition;
        }
    }
}
