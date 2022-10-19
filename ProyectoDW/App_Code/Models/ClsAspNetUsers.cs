using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Models
{
    public class ClsAspNetUsers
    {
        private String idCliente;
        private String emailCliente;
        private String userName;
        private int codigo;

        public string IdCliente
        {
            get
            {
                return idCliente;
            }

            set
            {
                idCliente = value;
            }
        }

        public string EmailCliente
        {
            get
            {
                return emailCliente;
            }

            set
            {
                emailCliente = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }
    }
}