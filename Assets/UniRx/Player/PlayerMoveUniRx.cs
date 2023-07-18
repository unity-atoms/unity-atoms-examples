using UnityEngine;
using Marvelous;
using UniRx;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.Examples
{
    /// <summary>
    /// Simple Player move script using UniRx.
    /// </summary>
    public class PlayerMoveUniRx : MonoBehaviour
    {
        [SerializeField]
        private StringVariable _uiState;
        [SerializeField]
        private StringConstant _uiStatePlaying;
        [SerializeField]
        private Vector2Variable _movementInput;

        private void Awake()
        {
            float _horizontal = 0f, _vertical = 0f;
            string HORIZONTAL = "Horizontal", VERTICAL = "Vertical";

            Observable
                .EveryUpdate()
                .Fuse<long, string>(
                    _uiState.ObserveChange(),
                    initialValue2: _uiState.Value
                ).Subscribe(t =>
                {
                    var (_, state) = t;
                    _horizontal = state == _uiStatePlaying.Value ? _movementInput.Value.x : 0f;
                    _vertical = state == _uiStatePlaying.Value ? _movementInput.Value.y : 0f;
                });

            Observable
                .EveryFixedUpdate()
                .Subscribe(t =>
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(_horizontal, _vertical) * 5f;
                });
        }
    }
}
