using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.Examples
{
    /// <summary>
    /// Simple move script for the Player.
    /// </summary>
    [AddComponentMenu("Unity Atoms/Examples/PlayerMove")]
    public class PlayerMove : MonoBehaviour
    {
        [SerializeField]
        private Vector2Variable _movementInput;

        private void Update()
        {
            GetComponent<Rigidbody2D>().Move(_movementInput.Value, 5f, Time.deltaTime);
        }
    }
}