using System;
namespace biblioUsuario
{
    public class Usuarios
    {
        private string nomUsuario;
        private string password;
        public Usuarios(string nomUsuario, string password)
        {
            NomUsuario = nomUsuario;
            Password = password;
        }
        #region Propiedades
        public string NomUsuario { get => nomUsuario; set => nomUsuario = value; }
        public string Password { get => password; set => password = value; }
        #endregion
    }
}

