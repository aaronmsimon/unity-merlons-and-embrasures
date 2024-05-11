using System;
using RoboRyanTron.Unite2017.Events;
using UnityEngine;

namespace MandE.Game
{
    [CreateAssetMenu(fileName = "New Inventory", menuName = "Scriptable Objects/Inventory")]
    public class Inventory : ScriptableObject
    {
        // [SerializeField] private string itemName; // is this needed?
        [SerializeField] private float itemCount;
        [SerializeField] private GameObject prefab;
        [SerializeField] private GameEvent itemCountChanged;

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
            itemCountChanged.Raise();
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
