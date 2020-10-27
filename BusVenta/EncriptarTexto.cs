using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusVenta
{
    public class EncriptarTexto
    {
        public static string Encriptar(string texto)
        {

            try
            {
                string key = "sisventasD100217HMO2020asdfñlk";
                byte[] keyArray;

                byte[] ArregloCifrar = UTF8Encoding.UTF8.GetBytes(texto);

                MD5CryptoServiceProvider hasdmd5 = new MD5CryptoServiceProvider();

                keyArray = hasdmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hasdmd5.Clear();

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cryptoTransform = tdes.CreateEncryptor();
                byte[] arrayResultado = cryptoTransform.TransformFinalBlock(ArregloCifrar, 0, ArregloCifrar.Length);
                tdes.Clear();

                texto = Convert.ToBase64String(arrayResultado, 0, arrayResultado.Length);

            }
            catch (Exception ex)
            {
            }
            return texto;
        }

        public static string Desencriptar(string textoEncriptado)
        {
            try
            {
                string key  = "sisventasD100217HMO2020asdfñlk";
                byte [] keyArray;
                byte[] ArrayDescifrar = Convert.FromBase64String( textoEncriptado );

                MD5CryptoServiceProvider mD5CryptoService = new MD5CryptoServiceProvider();
                keyArray = mD5CryptoService.ComputeHash( UTF8Encoding.UTF8.GetBytes( key ) );
                mD5CryptoService.Clear();

                TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
                tripleDES.Key = keyArray;
                tripleDES.Mode = CipherMode.ECB;
                tripleDES.Padding = PaddingMode.PKCS7;

                ICryptoTransform cryptoTransform = tripleDES.CreateDecryptor();
                byte[] arrayResult = cryptoTransform.TransformFinalBlock( ArrayDescifrar, 0, ArrayDescifrar.Length );

                tripleDES.Clear();
                textoEncriptado = UTF8Encoding.UTF8.GetString( arrayResult );
            }
            catch (Exception ex)
            {
            }

            return textoEncriptado;
        }
    }
}
