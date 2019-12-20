using System.Security.Cryptography;
using System.Text;
using System.IO;
using System;

namespace Utility
{
    /// <summary>
    /// Encryption utility functions.
    /// </summary>
    public sealed class EncryptUtil
    {
        private EncryptUtil() { }  // Makes this a static class.  No instantiation.


        public readonly static string SharedCompiledKey = "SharedEncryptionPassword";
        public readonly static string DefaultSaltValue = "3BB84119FC0743E194F2D20111FBD2C2";
        public static readonly string EncryptionFlag = "986A2AE1CB3A4ED984876CF8B877B20A";

        /// <summary>
        /// Get an MD5 Hash for an input string
        /// </summary>
        static public string GetMd5Hash(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;

            byte[] data;
            using (MD5 md5Hash = MD5.Create())
            {
                data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2").ToLower());
            }

            return sb.ToString();
        }

        public static bool IsDataEncrypted(string data)
        {
            bool isEncrypted = false;

            if (!string.IsNullOrEmpty(data) && data.Contains(EncryptUtil.EncryptionFlag, StringComparison.OrdinalIgnoreCase) && data.Substring(0, 32).EqualsIgnoreCase((EncryptUtil.EncryptionFlag)))
            {

                isEncrypted = true;
            }

            return isEncrypted;
        }

        public static string AddEncryptionFlag(string data)
        {
            //if(!string.IsNullOrEmpty(data) && data.Contains(EncryptUtil.EncryptionFlag))
            StringBuilder finalData = new StringBuilder();
            if (!string.IsNullOrEmpty(data))
            {

                if (EncryptUtil.IsDataEncrypted(data))
                {
                    throw new Exception("Data is already encrypted. Cannot double encrypt the data");
                }

                finalData.Append(EncryptUtil.EncryptionFlag);
                finalData.Append(data);
            }
            return finalData.ToString();
        }

        public static string RemoveEncryptionFlag(string data)
        {
            StringBuilder finalData = new StringBuilder();

            if (!string.IsNullOrEmpty(data) && data.Contains(EncryptUtil.EncryptionFlag, StringComparison.OrdinalIgnoreCase) && data.Substring(0, 32).EqualsIgnoreCase((EncryptUtil.EncryptionFlag)))
            {
                finalData.Append(data.Remove(0, 32));
            }

            return finalData.ToString();
        }

        public static string Encrypt<T>(string symmetricKey, string textToEncrypt, string salt)
         where T : SymmetricAlgorithm, new()
        {
            StringBuilder finalString = new StringBuilder();

            if (string.IsNullOrEmpty(symmetricKey))
                throw new Exception("symmetricKey cannot be null or empty.");
            if (string.IsNullOrEmpty(salt))
                throw new Exception("salt cannot be null or empty.");
            if (string.IsNullOrEmpty(textToEncrypt))
                return string.Empty;

            textToEncrypt = textToEncrypt.Trim();

            if (EncryptUtil.IsDataEncrypted(textToEncrypt))
            {
                finalString.Append(textToEncrypt);
            }
            else
            {
                DeriveBytes rgb = new Rfc2898DeriveBytes(symmetricKey, Encoding.Unicode.GetBytes(salt));

                SymmetricAlgorithm algorithm = new T();

                byte[] rgbKey = rgb.GetBytes(algorithm.KeySize >> 3);
                byte[] rgbIV = rgb.GetBytes(algorithm.BlockSize >> 3);

                ICryptoTransform transform = algorithm.CreateEncryptor(rgbKey, rgbIV);

                using (MemoryStream buffer = new MemoryStream())
                {
                    using (CryptoStream stream = new CryptoStream(buffer, transform, CryptoStreamMode.Write))
                    {
                        using (StreamWriter writer = new StreamWriter(stream, Encoding.Unicode))
                        {
                            writer.Write(textToEncrypt);
                        }
                    }
                    string encryptedString = Convert.ToBase64String(buffer.ToArray());

                    finalString.Append(EncryptUtil.AddEncryptionFlag(encryptedString));
                }
            }
            return finalString.ToString();
        }

        public static string Decrypt<T>(string symmetricKey, string textToDecrypt, string salt)
           where T : SymmetricAlgorithm, new()
        {
            if (string.IsNullOrEmpty(symmetricKey))
                throw new Exception("symmetricKey cannot be null or empty.");
            if (string.IsNullOrEmpty(salt))
                throw new Exception("salt cannot be null or empty.");
            if (string.IsNullOrEmpty(textToDecrypt))
                return string.Empty;

            string finalDecryptedString = string.Empty;
            textToDecrypt = textToDecrypt.Trim();
            if (EncryptUtil.IsDataEncrypted(textToDecrypt))
            {
                textToDecrypt = EncryptUtil.RemoveEncryptionFlag(textToDecrypt);

                DeriveBytes rgb = new Rfc2898DeriveBytes(symmetricKey, Encoding.Unicode.GetBytes(salt));

                SymmetricAlgorithm algorithm = new T();

                byte[] rgbKey = rgb.GetBytes(algorithm.KeySize >> 3);
                byte[] rgbIV = rgb.GetBytes(algorithm.BlockSize >> 3);

                ICryptoTransform transform = algorithm.CreateDecryptor(rgbKey, rgbIV);

                using (MemoryStream buffer = new MemoryStream(Convert.FromBase64String(textToDecrypt)))
                {
                    using (CryptoStream stream = new CryptoStream(buffer, transform, CryptoStreamMode.Read))
                    {
                        using (StreamReader reader = new StreamReader(stream, Encoding.Unicode))
                        {
                            finalDecryptedString = reader.ReadToEnd();
                        }
                    }
                }
            }
            else
            {
                finalDecryptedString = textToDecrypt;
            }

            return finalDecryptedString;
        }
    }
}
