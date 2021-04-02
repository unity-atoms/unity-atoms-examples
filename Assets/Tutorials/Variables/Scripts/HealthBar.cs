using UnityEngine;
using UnityEngine.UI;
using UnityAtoms.BaseAtoms;

namespace Tutorials.Variables
{
    public class HealthBar : MonoBehaviour
    {
        [SerializeField]
        private IntVariable Health;
        [SerializeField]
        private IntConstant MaxHealth;

        void Update()
        {
            GetComponent<Image>().fillAmount = 1.0f * Health.Value / MaxHealth.Value;
        }
    }
}
