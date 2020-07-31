using System;
using System.Collections.Generic;
using System.Text;
using Datos;
using System.Data;
using System.Security.Cryptography;

namespace Negocios
{
    public class Usuario
    {
        private DaoUsuario daoUsuario = new DaoUsuario();

        public DataTable Login(string usuario, string contrasenia)
        {
            DataTable dataTableLogin = new DataTable();
            dataTableLogin = daoUsuario.Login(usuario, contrasenia);
            return dataTableLogin;
        }

        public string GetSHA1(String password)
        {
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            Byte[] textOriginal = ASCIIEncoding.Default.GetBytes(password);
            Byte[] hash = sha1.ComputeHash(textOriginal);
            StringBuilder cadena = new StringBuilder();
            foreach (byte i in hash)
            {
                cadena.AppendFormat("{0:x2}", i);
            }
            return cadena.ToString();
        }
    }
}
