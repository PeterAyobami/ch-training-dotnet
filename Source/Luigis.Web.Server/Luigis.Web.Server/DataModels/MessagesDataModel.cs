namespace Luigis.Web.Server
{
    /// <summary>
    /// The messages database table representational model
    /// </summary>
    public class MessagesDataModel
    {
        /// <summary>
        /// The unique id for this entry
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The name of the massenger
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
