using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Models
{
    public class ClsAnuncio
    {
        private int idAnuncio;
        private string imagen;
        private DateTime fechaInicial;
        private DateTime fechaFinal;

        public int IdAnuncio
        {
            get
            {
                return idAnuncio;
            }

            set
            {
                idAnuncio = value;
            }
        }

        public string Imagen
        {
            get
            {
                return imagen;
            }

            set
            {
                imagen = value;
            }
        }

        public DateTime FechaInicial
        {
            get
            {
                return fechaInicial;
            }

            set
            {
                fechaInicial = value;
            }
        }

        public DateTime FechaFinal
        {
            get
            {
                return fechaFinal;
            }

            set
            {
                fechaFinal = value;
            }
        }
    }
}