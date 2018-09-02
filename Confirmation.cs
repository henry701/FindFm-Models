namespace Models
{
    /// <summary>
    /// Class for e-mail confirmation of a <see cref="Models.User"/>.
    /// </summary>
    [RootEntity]
    public class Confirmation : BaseEntity<string>
    {
        /// <summary>
        /// The user which the token confirms.
        /// </summary>
        public User User { get; set; }
    }
}