namespace Models
{
    /// <summary>
    /// Class for e-mail confirmation of a <see cref="Models.User"/>.
    /// </summary>
    public class Confirmation : IIdentifiable<string>
    {
        /// <summary>
        /// The confirmation token, as a base64 <see cref="string"/>.
        /// </summary>
        public string _id { get; set; }
        /// <summary>
        /// The user which the token confirms.
        /// </summary>
        public User User { get; set; }
    }
}