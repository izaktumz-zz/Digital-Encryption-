namespace EncryptionLib
{
    /// <summary>
    /// A Class that holds the encryption details
    /// </summary>
    public class EncryptionModel
    {
        /// <summary>
        /// The encrypted message
        /// </summary>
        public byte[] EncryptedMessage { get; set; }
        /// <summary>
        /// The key used to encrypt the message.Use it to decrypt the message
        /// </summary>
        public byte[] Key { get; set; }
        /// <summary>
        /// The IV used to encrypt the message.Use it to decrypt the message.
        /// The IV and the Key are required to encrypt and decrypt the message.
        /// Store them for later use.
        /// </summary>
        public byte[] IV { get; set; }
    }
}
