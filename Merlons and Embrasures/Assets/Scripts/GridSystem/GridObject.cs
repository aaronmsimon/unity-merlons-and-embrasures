using CodeMonkey.Grid;
using MandE.Buildings;

namespace MandE.Grid
{
    public class GridObject
    {
        private GridSystem gridSystem;
        private GridPosition gridPosition;
        private Building building;

        public GridObject(GridSystem gridSystem, GridPosition gridPosition)
        {
            this.gridSystem = gridSystem;
            this.gridPosition = gridPosition;
        }
    }
}
