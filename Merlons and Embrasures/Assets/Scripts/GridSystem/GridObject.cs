using CodeMonkey.Grid;
using MandE.Buildings;
using UnityEngine;

namespace MandE.Grid
{
    public class GridObject
    {
        private GridSystem gridSystem;
        private GridPosition gridPosition;
        private Building building;
        private Transform cellTransform;

        public GridObject(GridSystem gridSystem, GridPosition gridPosition)
        {
            this.gridSystem = gridSystem;
            this.gridPosition = gridPosition;
        }

        public Transform CellTransform
        {
            get
            {
                return cellTransform;
            }
            set
            {
                cellTransform = value;
            }
        }
    }
}
