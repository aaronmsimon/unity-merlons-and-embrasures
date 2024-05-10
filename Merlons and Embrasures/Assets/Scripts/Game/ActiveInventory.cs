// using System;
using UnityEngine;

namespace MandE.Game
{
    [CreateAssetMenu(fileName = "New ActiveInventory", menuName = "Scriptable Objects/Active Inventory")]
    public class ActiveInventory : ScriptableObject
    {
        [SerializeField] private Inventory currentActive;

        // public event EventHandler CurrentInventoryChanged;
        
        public Inventory CurrentActive
        {
            get
            {
                return currentActive;
            }
        }

        public void SetActive(Inventory newActive)
        {
            currentActive = newActive;
            // CurrentInventoryChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
