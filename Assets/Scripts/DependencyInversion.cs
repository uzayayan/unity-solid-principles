using UnityEngine;

namespace SPACE.DIP
{
    public class DependencyInversion : MonoBehaviour
    {
        #region Private Fields

        private ICharacterAbility _characterAbility;

        /*
         * If we reference the abilities from the class in this way, we would violate the principle we are using.
         * Because higher-level should never be dependent on lower-level.
         * In other words, the upper-level should not have any direct dependencies on the lower-level.
         * 
        private IceAbility _iceAbility;
        private FireAbility _fireAbility;
        private StormAbility _stormAbility;
        */
            
        #endregion
        
        /// <summary>
        /// Helps for initialization.
        /// </summary>
        private void Awake()
        {
            Debug.Log("Dependency Inversion Principle example started.");
            
            _characterAbility = new IceAbility();
            _characterAbility.Use();
            
            _characterAbility = new FireAbility();
            _characterAbility.Use();

            _characterAbility = new StormAbility();
            _characterAbility.Use();
            
            Debug.Log("Please review 'DependencyInversion.cs' for more information.");
        }
    }

    /// <summary>
    /// Character Ability Interface.
    /// </summary>
    public interface ICharacterAbility
    {
        /// <summary>
        /// Helps for use.
        /// </summary>
        public void Use();
    }
    
    /// <summary>
    /// Ice Ability.
    /// </summary>
    public class IceAbility : ICharacterAbility
    {
        /// <summary>
        /// Helps for use.
        /// </summary>
        public void Use()
        {
            //Ice operation.
            
            Debug.Log("Ice ability.");
        }
    }

    /// <summary>
    /// Fire Ability.
    /// </summary>
    public class FireAbility : ICharacterAbility
    {
        /// <summary>
        /// Helps for use.
        /// </summary>
        public void Use()
        {
            //Fire operation.
            
            Debug.Log("Fire ability.");
        }
    }

    /// <summary>
    /// Storm Ability.
    /// </summary>
    public class StormAbility : ICharacterAbility
    {
        /// <summary>
        /// Helps for use.
        /// </summary>
        public void Use()
        {
            //Storm operation.
            
            Debug.Log("Storm ability.");
        }
    }
}