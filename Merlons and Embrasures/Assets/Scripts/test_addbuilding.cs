using MandE.Buildings;
using UnityEngine;

namespace MandE.testing
{
    public class TestAddBuilding : MonoBehaviour
    {
        [SerializeField] private BuildingsRuntimeSet runtimeSet;
        
        public void ReadBuildings()
        {
            for (int i = 0; i < runtimeSet.Items.Count; i++)
            {
                Debug.Log(runtimeSet.Items[i].transform.position);
            }
        }
    }
}
