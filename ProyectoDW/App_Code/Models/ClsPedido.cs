using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Models
{
    public class ClsPedido
    {
        private int idPedido;
        private int idUsuario;
        private int idEstado;
        private string nit;
        private string nombreCliente;
        private DateTime fechaPedido;
        private float monto;

        public int IdPedido
        {
            get
            {
                return idPedido;
            }

            set
            {
                idPedido = value;
            }
        }

        public int IdUsuario
        {
            get
            {
                return idUsuario;
            }

            set
            {
                idUsuario = value;
            }
        }

        public int IdEstado
        {
            get
            {
                return idEstado;
            }

            set
            {
                idEstado = value;
            }
        }

        public string Nit
        {
            get
            {
                return nit;
            }

            set
            {
                nit = value;
            }
        }

        public string NombreCliente
        {
            get
            {
                return nombreCliente;
            }

            set
            {
                nombreCliente = value;
            }
        }

        public DateTime FechaPedido
        {
            get
            {
                return fechaPedido;
            }

            set
            {
                fechaPedido = value;
            }
        }

        public float Monto
        {
            get
            {
                return monto;
            }

            set
            {
                monto = value;
            }
        }
    }
}