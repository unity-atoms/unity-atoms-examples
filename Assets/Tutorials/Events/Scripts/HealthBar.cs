using UnityEngine;
using UnityEngine.UI;
using UnityAtoms.BaseAtoms;

namespace Tutorials.Events
{
    public class HealthBar : MonoBehaviour
    {
        [SerializeField]
        private IntEvent HealthChangedEvent;
        [SerializeField]
        private IntConstant MaxHealth;

        void Start()
        {
            HealthChangedEvent.Register(this.ChangeFillAmount);
        }

        void OnDestroy()
        {
            HealthChangedEvent.Unregister(this.ChangeFillAmount);
        }

        private void ChangeFillAmount(int health)
        {
            GetComponent<Image>().fillAmount = 1.0f * health / MaxHealth.Value;
        }
    }
}
