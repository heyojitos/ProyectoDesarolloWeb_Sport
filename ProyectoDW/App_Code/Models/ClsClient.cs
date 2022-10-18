using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Models
{
    
    public class ClsClient
    {
        private int idCliente;
        private String nombre;
        private String apellido;
        private String correo;
        private String clave;
        private Boolean reestablecer;
        private String fechaReg;

        public int IdCliente
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

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }

        public string Clave
        {
            get
            {
                return clave;
            }

            set
            {
                clave = value;
            }
        }

        public bool Reestablecer
        {
            get
            {
                return reestablecer;
            }

            set
            {
                reestablecer = value;
            }
        }

        public string FechaReg
        {
            get
            {
                return fechaReg;
            }

            set
            {
                fechaReg = value;
            }
        }
    }
}