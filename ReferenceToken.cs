namespace Models
{
    /// <summary>
    /// Class for e-mail referencing of a <see cref="Models.User"/>.
    /// </summary>
    [RootEntity]
    public class ReferenceToken : BaseEntity<string>
    {
        /// <summary>
        /// The user which the token references.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// The type of operation this token references.
        /// </summary>
        public TokenType TokenType { get; set; }
    }
}