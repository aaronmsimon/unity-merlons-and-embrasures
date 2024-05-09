using UnityEngine;

namespace MandE.Game
{
    [CreateAssetMenu(fileName = "New Inventory", menuName = "Scriptable Objects/Inventory")]
    public class Inventory : ScriptableObject
    {
        [SerializeField] private string itemName;
        [SerializeField] private float itemCount;
        
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
        }
    }
}
