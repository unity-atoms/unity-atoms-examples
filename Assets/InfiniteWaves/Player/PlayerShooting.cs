using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.Examples
{
    /// <summary>
    /// Simple shooting scipt for the player using the arrow keys.
    /// </summary>
    public class PlayerShooting : MonoBehaviour
    {
        [SerializeField]
        private GameObject _projectile;

        [SerializeField]
        private StringConstant _playerTag;


        private enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }
        void Shoot(Direction direction)
        {
            var shootDirection = Vector3.zero;
            var rot = Quaternion.identity;
            switch (direction)
            {
                case Direction.Up:
                    {
                        shootDirection = Vector3.up;
                        rot = Quaternion.Euler(0f, 0f, 90f);
                        break;
                    }
                case Direction.Down:
                    {
                        shootDirection = Vector3.down;
                        rot = Quaternion.Euler(0f, 0f, -90f);
                        break;
                    }
                case Direction.Right:
                    {
                        shootDirection = Vector3.right;
                        rot = Quaternion.Euler(0f, 0f, 0f);
                        break;
                    }
                case Direction.Left:
                    {
                        shootDirection = Vector3.left;
                        rot = Quaternion.Euler(0f, 0f, 180f);
                        break;
                    }
            }

            var spawnPos = transform.position + shootDirection * 0.6f;
            var projectile = Instantiate(_projectile, spawnPos, rot);
            projectile.GetComponent<DecreaseHealth>().TagsAffected.Remove(_playerTag); // Turn off friendly fire
        }

        public void ShootUp()
        {
            Shoot(Direction.Up);
        }

        public void ShootDown()
        {
            Shoot(Direction.Down);
        }

        public void ShootLeft()
        {
            Shoot(Direction.Left);
        }

        public void ShootRight()
        {
            Shoot(Direction.Right);
        }
    }
}