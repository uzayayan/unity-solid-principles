using UnityEngine;

namespace SPACE.SRP
{
    public class SingleResponsibility : MonoBehaviour
    {
        /// <summary>
        /// Helps for initialization.
        /// </summary>
        private void Awake()
        {
            Debug.Log("Single Responsibility Principle example started.");
            
            MailManager mailManager = new MailManager();
            mailManager.SendMail("Title", "Message", "TargetMail");

            Debug.Log("Please review 'SingleResponsibility.cs' for more information.");
        }
    }

    /// <summary>
    /// Mail Manager.
    /// </summary>
    public class MailManager
    {
        #region Private Fields

        private MailValidator _mailValidator;

        #endregion

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <returns></returns>
        public MailManager()
        {
            _mailValidator = new MailValidator();
        }

        /// <summary>
        /// Helps for send mail.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <param name="targetMail"></param>
        public void SendMail(string title, string message, string targetMail)
        {
            if(!_mailValidator.IsValid(targetMail))
                return;
            
            //Send operation.
        }
        
        /*
         * If this method were in this class, it would be against the SRP we used.
         *
        public bool IsValid(string mail)
        {
            return true;
        }
        */
    }

    /// <summary>
    /// Mail Validator.
    /// </summary>
    public class MailValidator
    {
        /// <summary>
        /// Returns true if target mail is valid.
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        public bool IsValid(string mail)
        {
            return true;
        }
    }
}