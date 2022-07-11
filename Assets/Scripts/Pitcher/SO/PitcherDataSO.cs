using System.Collections.Generic;
using UnityEngine;

namespace Pitcher
{
    [CreateAssetMenu(fileName = "PitcherData", menuName = "ScriptableObjects/PitcherData", order = 1)]
    public class PitcherDataSO : ScriptableObject
    {
        [Range(50,100)] public float Stamina;
        [Range(50,100)] public int Control;
        public List<PitchTypeSO> PitchTypes = new List<PitchTypeSO>();
    }
}

