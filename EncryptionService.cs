using System.IO;
using System.Security.Cryptography;
using System.Text;
namespace EncryptionLib
{
    public class EncryptionService
    {
        
        #region Methods
        /// <summary>
        /// Returns a model with encryption details required when decrypting data.
        /// </summary>
        /// <param name="data">The data to encrypt.</param>
        /// <returns></returns>
        public EncryptionModel EncryptData(string data)
        {

            using (SymmetricAlgorithm alg=new AesManaged())
            {
                ICryptoTransform encryptor = alg.CreateEncryptor(alg.Key, alg.IV);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs, Encoding.UTF8))
                        {
                            sw.Write(data);
                        }
                    }
                    return new EncryptionModel()
                    {
                         EncryptedMessage=ms.ToArray(), IV=alg.IV,Key=alg.Key
                    };
                }
            }
        }
        /// <summary>
        /// returns the original message
        /// </summary>
        /// <param name="cipherText">the encrypted message</param>
        /// <param name="key">the key used for encryption</param>
        /// <param name="iv">the key used for decryption</param>
        /// <returns></returns>
        public string DecryptData(byte[]cipherText,byte[] key,byte[]iv)
        {
            using (SymmetricAlgorithm alg=new AesManaged())
            {
                ICryptoTransform decryptor = alg.CreateDecryptor(key, iv);
                using (MemoryStream ms = new MemoryStream(cipherText))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            return sr.ReadToEnd();
                        }
                    }
                }
            }  
        }
        #endregion
    }
}
