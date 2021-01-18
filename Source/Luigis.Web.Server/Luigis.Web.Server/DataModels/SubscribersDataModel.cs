namespace Luigis.Web.Server
{
    /// <summary>
    /// The subscribers database table representational model
    /// </summary>
    public class SubscribersDataModel
    {
        /// <summary>
        /// The unique id for this entry
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The email of the subscriber
        /// </summary>
        public string Email { get; set; }
    }
}
