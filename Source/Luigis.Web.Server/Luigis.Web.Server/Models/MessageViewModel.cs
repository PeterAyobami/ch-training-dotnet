namespace Luigis.Web.Server
{
    public class MessageViewModel
    {
        /// <summary>
        /// The name of the messenger
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The email of the messenger
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The subject specified by the messenger
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// The message of the messenger
        /// </summary>
        public string Message { get; set; }
    }
}
