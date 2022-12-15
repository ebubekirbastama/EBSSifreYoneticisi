using System.Security.Cryptography;
using System.Text;

namespace EBSSifreYoneticisi
{
    internal class Ebssfryntcs
    {
        public static int passwd = 15;
        public static string exmsg = "EBS Şifre Yöneticisi";

        public static string SifreleVeyaCoz(string metin, int yerDegistirmeBoyutu)
        {
           
            char[] harfler = metin.ToCharArray();
            for (int i = 0; i < harfler.Length; i++)
            {
                char harf = harfler[i];
                harf = (char)(harf + yerDegistirmeBoyutu);
                if (harf > 'z')
                {
                    harf = (char)(harf - 26);
                }
                else if (harf < 'a')
                {
                    harf = (char)(harf + 26);
                }
                harfler[i] = harf;
            }
            return new string(harfler);
        }


        public static string EBSVeriKaydet(string DosyaYolu, string YazilacakVeri, DataGridView dw)
        {
            string msj = "";
            if (dw.RowCount == 0)
            {
                System.IO.FileStream fs = new System.IO.FileStream(DosyaYolu, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write);
                fs.Close();
                System.IO.File.AppendAllText(DosyaYolu, YazilacakVeri);
                msj = "Kayıt Başarılı";

            }
            else
            {

                System.IO.FileStream fs = new System.IO.FileStream(DosyaYolu, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write);
                fs.Close();
                System.IO.File.AppendAllText(DosyaYolu, Environment.NewLine + YazilacakVeri);
                msj = "Kayıt Başarılı";
            }
            return msj;
        }


        public static string Sha1Hash(string input, int kac)
        {

            for (int i = 0; i < kac; i++)
            {
                SHA1 sha = new SHA1CryptoServiceProvider();
                ASCIIEncoding encoder = new ASCIIEncoding();
                byte[] combined = encoder.GetBytes(input);
                input = BitConverter.ToString(sha.ComputeHash(combined)).Replace("-", "").ToLower();
            }

            return input;
        }
        public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;

            byte[] saltBytes = new byte[] { 2, 1, 7, 3, 6, 4, 8, 5 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }

        public static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;

            byte[] saltBytes = new byte[] { 2, 1, 7, 3, 6, 4, 8, 5 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }
                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
        }

    }
}
