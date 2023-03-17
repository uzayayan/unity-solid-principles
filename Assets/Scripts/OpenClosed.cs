using UnityEngine;

namespace SPACE.OCP
{
    public class OpenClosed : MonoBehaviour
    {
        /// <summary>
        /// Helps for initialization.
        /// </summary>
        private void Awake()
        {
            Debug.Log("Open Closed Principle example started.");
            
            MailManager googleMailManager = new MailManager(new GoogleMailValidator());
            googleMailManager.SendMail("Title", "Message", "sample@gmail.com");
            
            MailManager microsoftMailManager = new MailManager(new MicrosoftMailValidator());
            microsoftMailManager.SendMail("Title", "Message", "sample@outlook.com");
            
            Debug.Log("Please review 'OpenClosed.cs' for more information.");
        }
    }
    
    /// <summary>
    /// Mail Manager.
    /// </summary>
    public class MailManager
    {
        #region Private Fields

        private IMailValidator _mailValidator;

        #endregion
        
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <returns></returns>
        public MailManager(IMailValidator mailValidator)
        {
            _mailValidator = mailValidator;
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
            
            //Send progress.
        }
    }

    /// <summary>
    /// Mail Validator Interface. 
    /// </summary>
    public interface IMailValidator
    {
        bool IsValid(string mail);
    }
    
    /// <summary>
    /// Microsoft Mail Validator.
    /// </summary>
    public class MicrosoftMailValidator : IMailValidator
    {
        /// <summary>
        /// Returns true if target mail is valid.
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        public bool IsValid(string mail)
        {
            if (!mail.Contains("@outlook.com"))
                return false;
            
            Debug.Log("Micorosft mail is valid.");
            
            return true;
        }
    }
    
    /// <summary>
    /// Google Mail Validator.
    /// </summary>
    public class GoogleMailValidator : IMailValidator
    {
        /// <summary>
        /// Returns true if target mail is valid.
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        public bool IsValid(string mail)
        {
            if (!mail.Contains("@gmail.com"))
                return false;
            
            Debug.Log("Google mail is valid.");

            return true;
        }
    }
}