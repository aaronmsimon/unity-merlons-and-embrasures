using System;

namespace CodeMonkey.Grid
{
    public struct GridPosition : IEquatable<GridPosition>
    {
        public int x;
        public int z;

        public GridPosition(int x, int z)
        {
            this.x = x;
            this.z = z;
        }

        public override string ToString()
        {
            return "<color=#E46252>x</color><color=#FFFFFF> " + x + ",</color> <color=#5E88F5>z</color><color=#FFFFFF> " + z + "</color>";
        }

        public static bool operator ==(GridPosition a, GridPosition b)
        {
            return a.x == b.x && a.z == b.z;
        }

        public static bool operator !=(GridPosition a, GridPosition b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            return obj is GridPosition position &&
                    x == position.x &&
                    z == position.z;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(x, z);
        }

        public bool Equals(GridPosition other)
        {
            return this == other;
        }
    }
}
