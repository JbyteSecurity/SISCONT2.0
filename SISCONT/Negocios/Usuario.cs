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

        public DataTable Login(string usuario, string contrasenia) { return daoUsuario.Login(usuario, GetSHA1(contrasenia)); }

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

        public DataTable All() { return daoUsuario.All(); }

        public DataTable Show(string usuario) { return daoUsuario.Show(usuario); }

        public bool Insert(string usuario, string contrasenia, string nombre, string correo, string telefono, int rolId) {
            return daoUsuario.Insert(usuario, GetSHA1(contrasenia), nombre, correo, telefono, rolId);
        }

        public bool Update(int id, string usuario, string contrasenia, string nombre, string correo, string telefono, int rolId)
        {
            return daoUsuario.Update(id, usuario, GetSHA1(contrasenia), nombre, correo, telefono, rolId);
        }

        public bool Destroy(int id) { return daoUsuario.Destroy(id); }
    }
}
