using UnityEngine;
using UnityEngine.UI;
using UnityAtoms.BaseAtoms;

namespace Tutorials.Listeners
{
    public class HealthBar : MonoBehaviour
    {
        [SerializeField]
        private IntConstant MaxHealth;

        public void ChangeFillAmount(int health)
        {
            GetComponent<Image>().fillAmount = 1.0f * health / MaxHealth.Value;
        }
    }
}
