using UnityEngine;

namespace MandE.Buildings
{
    public class Building : MonoBehaviour
    {
        [SerializeField] LevelBuildingsRuntimeSet runtimeSet;

        public int id;

        private void OnEnable()
        {
            runtimeSet.Add(this);
        }

        private void OnDisable()
        {
            runtimeSet.Remove(this);
        }
    }
}
