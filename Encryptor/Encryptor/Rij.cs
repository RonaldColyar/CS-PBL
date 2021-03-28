using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;


namespace Rij
{
    public class RijAlgo
    {
        public void EncryptFile(string inputFile, string outputFile)
        {

            try
            {
                RijndaelManaged RMCrypto = new RijndaelManaged();
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(RMCrypto.IV.ToString());

                string cryptFile = outputFile;
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

                
                

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateEncryptor(key, key),
                    CryptoStreamMode.Write);

                FileStream fsIn = new FileStream(inputFile, FileMode.Open);

                int data;
                while ((data = fsIn.ReadByte()) != -1)
                    cs.WriteByte((byte)data);


                fsIn.Close();
                cs.Close();
                fsCrypt.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void DecryptFile(string inputFile, string outputFile, string password)
        {

            {

                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateDecryptor(key, key),
                    CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(outputFile, FileMode.Create);

                int data;
                while ((data = cs.ReadByte()) != -1)
                    fsOut.WriteByte((byte)data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();

            }
        }
    }
}