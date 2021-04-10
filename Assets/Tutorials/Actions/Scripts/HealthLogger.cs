using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace Tutorials.Actions
{
    [CreateAssetMenu(menuName = "Unity Atoms/Examples/Health Logger")]
    public class HealthLogger : IntAction
    {
        public override void Do(int health)
        {
            Debug.Log("<3: " + health);
        }
    }
}
