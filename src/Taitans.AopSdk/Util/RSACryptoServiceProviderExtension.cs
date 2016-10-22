using System;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Runtime.InteropServices;


namespace Aop.Api.Util
{
    public static class RSACryptoServiceProviderExtension
    {
        /// <summary>Extension method which initializes an RSACryptoServiceProvider from a PEM public key string.</summary>
        public static void LoadPublicKeyPEM(RSACryptoServiceProvider provider, string sPEM)
        {
            sPEM = sPEM.Replace("-----BEGIN PUBLIC KEY-----", "");
            sPEM = sPEM.Replace("-----END PUBLIC KEY-----", "");
            sPEM = sPEM.Trim();

            byte[] publicKeyBytes = Convert.FromBase64String(sPEM);
            Org.BouncyCastle.Crypto.AsymmetricKeyParameter asymmetricKeyParameter = Org.BouncyCastle.Security.PublicKeyFactory.CreateKey(publicKeyBytes);
            Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters rsaKeyParameters = (Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)asymmetricKeyParameter;
            RSAParameters rsaParameters = new RSAParameters();
            rsaParameters.Modulus = rsaKeyParameters.Modulus.ToByteArrayUnsigned();
            rsaParameters.Exponent = rsaKeyParameters.Exponent.ToByteArrayUnsigned();
            provider.ImportParameters(rsaParameters);
        }
    }
}
