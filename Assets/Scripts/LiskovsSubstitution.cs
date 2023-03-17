using UnityEngine;

namespace SPACE.LSP
{
    public class LiskovsSubstitution : MonoBehaviour
    {
        /// <summary>
        /// Helps for initialization.
        /// </summary>
        private void Awake()
        {
            Debug.Log("Liskov's Substitution Principle example started.");
            Debug.Log("Please review 'LiskovsSubstitution.cs' for more information.");
        }
    }

    /// <summary>
    /// Character
    /// </summary>
    public abstract class Character
    {
        /// <summary>
        /// Helps for move.
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="speed"></param>
        public abstract void Move(Vector3 direction, float speed);
        
        /*
         * If this method were in this class, it would be against the LSP we used.
         * We leave the common methods of both Player and Bot in our abstract class.
         * Since only the Player will be controlled by the mouse, we implement the InputMouse interface to the Player.
         *
        public void Click(Vector2 mousePosition)
        {
            //Input operation.
        }
        */
    }
    
    /// <summary>
    /// Player.
    /// </summary>
    public class Player : Character, IMouseClick
    {
        /// <summary>
        /// Helps for move.
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="speed"></param>
        public override void Move(Vector3 direction, float speed)
        {
            //Move operation.
        }

        /// <summary>
        /// Called when player click to the screen.
        /// </summary>
        /// <param name="mousePosition"></param>
        public void Click(Vector2 mousePosition)
        {
            //Input operation.
        }
    }
    
    /// <summary>
    /// Bot.
    /// </summary>
    public class Bot : Character
    {
        /// <summary>
        /// Helps for move.
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="speed"></param>
        public override void Move(Vector3 direction, float speed)
        {
            //Move operation.
        }
    }

    /// <summary>
    /// Mouse Click Interface.
    /// </summary>
    public interface IMouseClick
    {
        /// <summary>
        /// Called when player click to the screen.
        /// </summary>
        /// <param name="mousePosition"></param>
        void Click(Vector2 mousePosition);
    }
}