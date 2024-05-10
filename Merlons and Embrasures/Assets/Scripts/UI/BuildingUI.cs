using System;
using MandE.Game;
using UnityEngine;
using TMPro;

namespace MandE.UI
{
    public class BuildingUI : MonoBehaviour
    {
        [SerializeField] private Inventory buildingInventory;
        [SerializeField] private TextMeshProUGUI textBuildingCount;

        private void Start()
        {
            buildingInventory.ItemCountChanged += OnItemCountChanged;

            UpdateBuildingCount();
        }

        private void UpdateBuildingCount()
        {
            textBuildingCount.text = buildingInventory.ItemCount.ToString();
        }

        private void OnItemCountChanged(object sender, EventArgs e)
        {
            UpdateBuildingCount();
        }
    }
}
