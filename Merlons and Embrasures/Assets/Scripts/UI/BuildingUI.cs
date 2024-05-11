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
        [SerializeField] private ActiveInventory buildingActiveInventory;

        private void Start()
        {
            UpdateBuildingCount();
        }

        public void UpdateBuildingCount()
        {
            textBuildingCount.text = buildingInventory.ItemCount.ToString();
        }

        public void OnClick()
        {
            buildingActiveInventory.SetActive(buildingInventory);
        }
    }
}
