using MandE.Buildings;
using UnityEngine;

namespace MandE.testing
{
    public class TestAddBuilding : MonoBehaviour
    {
        [SerializeField] private GameObject buildingPrefab;
        [SerializeField] private BuildingsRuntimeSet runtimeSet;

        public void AddBuilding()
        {
            Instantiate(buildingPrefab, Vector3.zero, Quaternion.identity);
        }

        public void ReadBuildings()
        {
            for (int i = 0; i < runtimeSet.Items.Count; i++)
            {
                Debug.Log(runtimeSet.Items[i].transform.position);
            }
        }
    }
}
