using Microsoft.Win32;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyClassLibrary.Classes
{
    public static class class_Tools
    {
        private const string passphrase = "webMh@rjun";

        public static string Encrypt(string sText)
        {
            byte[] Results;
            var UTF8 = new UTF8Encoding();
            var HashProvider = new MD5CryptoServiceProvider();
            var TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(passphrase));
            var TDESAlgorithm = new TripleDESCryptoServiceProvider()
            {
                Key = TDESKey,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            var DataToEncrypt = UTF8.GetBytes(sText);
            try
            {
                var Encryptor = TDESAlgorithm.CreateEncryptor();
                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
            }
            catch (Exception ex)
            {
                class_Procedures.Show_Error(ex);
                return null;
            }
            finally
            {
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }

            return Convert.ToBase64String(Results);
        }

        public static string Decrypt(string sText, string sDefault = "")
        {
            if (ReferenceEquals(sText, string.Empty))
                return string.Empty;
            byte[] Results;
            var UTF8 = new UTF8Encoding();
            var HashProvider = new MD5CryptoServiceProvider();
            var TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(passphrase));
            var TDESAlgorithm = new TripleDESCryptoServiceProvider()
            {
                Key = TDESKey,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            try
            {
                var DataToDecrypt = Convert.FromBase64String(sText);
                var Decryptor = TDESAlgorithm.CreateDecryptor();
                Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length);
            }
            catch (Exception ex)
            {
                class_Procedures.Show_Error(ex);
                return sDefault;
            }
            finally
            {
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }

            return UTF8.GetString(Results);
        }

        public static void ReplaceInFile(string OrigFile, string NewFile, string searchText, string replaceText)
        {
            var reader = new StreamReader(OrigFile);
            string content = reader.ReadToEnd();
            reader.Close();
            content = Regex.Replace(content, searchText, replaceText);
            using (var writer = new StreamWriter(NewFile))
            {
                writer.Write(content);
            }
        }

        public static void SubKeyTreeDelete(RegistryKey registryPath, string keyToDelete)
        {
            if (registryPath is object && !string.IsNullOrWhiteSpace(keyToDelete))
            {
                bool throwOnMissingSubKey = false;
                try
                {
                    registryPath.DeleteSubKeyTree(keyToDelete, throwOnMissingSubKey);
                }
                catch
                {
                }
            }
        }

        public static string RegKeyGet(string keySection, string keyName, string keyDefault)
        {
            string sPath = $@"{Application.ProductName}\\{keySection}\\{keyName}";
            var key = Registry.CurrentUser.OpenSubKey(sPath, true);
            if (key is null)
            {
                key = Registry.CurrentUser.CreateSubKey(sPath);
                key.SetValue(keyName, keyDefault);
            }

            return Convert.ToString(key.GetValue(keyName));
        }

        public static bool RegKeyGet(string keySection, string keyName, bool keyDefault)
        {
            string sPath = $@"{Application.ProductName}\\{keySection}\\{keyName}";
            var key = Registry.CurrentUser.OpenSubKey(sPath, true);
            if (key is null)
            {
                key = Registry.CurrentUser.CreateSubKey(sPath);
                key.SetValue(keyName, keyDefault);
            }

            return Convert.ToBoolean(key.GetValue(keyName));
        }

        public static int RegKeyGet(string keySection, string keyName, int keyDefault)
        {
            string sPath = $@"{Application.ProductName}\\{keySection}\\{keyName}";
            var key = Registry.CurrentUser.OpenSubKey(sPath, true);
            if (key is null)
            {
                key = Registry.CurrentUser.CreateSubKey(sPath);
                key.SetValue(keyName, keyDefault);
            }

            return Convert.ToInt32(key.GetValue(keyName));
        }

        public static decimal RegKeyGet(string keySection, string keyName, decimal keyDefault)
        {
            string sPath = $@"{Application.ProductName}\\{keySection}\\{keyName}";
            var key = Registry.CurrentUser.OpenSubKey(sPath, true);
            if (key is null)
            {
                key = Registry.CurrentUser.CreateSubKey(sPath);
                key.SetValue(keyName, keyDefault);
            }

            return Convert.ToDecimal(key.GetValue(keyName));
        }

        public static void RegKeySet(string keySection, string keyName, string keyValue)
        {
            if (keyValue is null)
                return;
            string sPath = $@"{Application.ProductName}\\{keySection}\\{keyName}";
            var key = Registry.CurrentUser.OpenSubKey(sPath, true);
            if (key is object)
            {
                key.SetValue(keyName, keyValue);
                key.Close();
            }
        }

        public static void RegKeySet(string keySection, string keyName, bool keyValue)
        {
            string sPath = $@"{Application.ProductName}\\{keySection}\\{keyName}";
            var key = Registry.CurrentUser.OpenSubKey(sPath, true);
            if (key is object)
            {
                key.SetValue(keyName, keyValue);
                key.Close();
            }
        }

        public static void RegKeySet(string keySection, string keyName, int keyValue)
        {
            string sPath = $@"{Application.ProductName}\\{keySection}\\{keyName}";
            var key = Registry.CurrentUser.OpenSubKey(sPath, true);
            if (key is object)
            {
                key.SetValue(keyName, keyValue);
                key.Close();
            }
        }

        public static void RegKeySet(string keySection, string keyName, decimal keyValue)
        {
            string sPath = $@"{Application.ProductName}\\{keySection}\\{keyName}";
            var key = Registry.CurrentUser.OpenSubKey(sPath, true);
            if (key is object)
            {
                key.SetValue(keyName, keyValue);
                key.Close();
            }
        }
    }
}