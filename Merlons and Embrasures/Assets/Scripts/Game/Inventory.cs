using System;
using UnityEngine;

namespace MandE.Game
{
    [CreateAssetMenu(fileName = "New Inventory", menuName = "Scriptable Objects/Inventory")]
    public class Inventory : ScriptableObject
    {
        [SerializeField] private string itemName;
        [SerializeField] private float itemCount;
        [SerializeField] private GameObject prefab;

        public event EventHandler ItemCountChanged;
        
        public float ItemCount
        {
            get
            {
                return itemCount;
            }
        }

        public void ChangeItemCount(float amount)
        {
            itemCount += amount;
            ItemCountChanged?.Invoke(this, EventArgs.Empty);
        }

        public GameObject Prefab
        {
            get
            {
                return prefab;
            }
        }
    }
}
