using UnityEngine;

namespace DefaultNamespace
{
    public class Player
    {
        public Vector3 Movement { get; }


        private Player(Vector3 movement)
        {
            Movement = movement;
        }

        public static Player Create(float axisX, float axisY, float axisZ, float velocity)
        {
            Vector3 movementByTime = new Vector3(axisX, axisY, axisZ) * Time.deltaTime;
            
            return new Player(movementByTime * velocity);
        }

        public bool IsMoving()
        {
            return Movement != Vector3.zero;
        }
    }
}