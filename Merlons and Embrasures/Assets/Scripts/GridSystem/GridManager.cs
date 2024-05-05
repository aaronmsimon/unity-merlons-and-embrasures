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
        [SerializeField] private Material highlightMat;
        [SerializeField] private MouseWorld mouseWorld;

        private Material originalMat;
        private GridSystem gridSystem;
        private GridObject highlightedGridObject;

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

            originalMat = cellPrefab.GetComponentInChildren<MeshRenderer>().sharedMaterial;
            Debug.Log("original mat: " + originalMat);
            Debug.Log("highlight mat: " + highlightMat);
            highlightedGridObject = gridSystem.GetGridObject(gridSystem.GetGridPosition(mouseWorld.Position));
        }

        private void Update()
        {
            GridObject selectedGridObject = gridSystem.GetGridObject(gridSystem.GetGridPosition(mouseWorld.Position));
            if (highlightedGridObject != selectedGridObject)
            {
                highlightedGridObject.CellTransform.GetComponentInChildren<MeshRenderer>().sharedMaterial = originalMat;
                selectedGridObject.CellTransform.GetComponentInChildren<MeshRenderer>().sharedMaterial = highlightMat;
                highlightedGridObject = selectedGridObject;
            }
        }
    }
}
