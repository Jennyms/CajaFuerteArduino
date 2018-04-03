using CajaFuerteArduinoENL;
using System.Collections.Generic;
using System.Xml;
using CajaFuerteArduinoDAL;
using System;

namespace CajaFuerteArduinoBOL
{
    public class PersonasBOL
    {
        private PersonasDAL dal;
        public PersonasBOL()
        {
            dal = new PersonasDAL();
        }

        public void CrearArchivo(string ruta, string nodoRaiz)
        {
            if (String.IsNullOrEmpty(ruta)
                || String.IsNullOrEmpty(nodoRaiz))
            {
                throw new Exception("Datos requeridos para crear archivo.");
            }
            dal.CrearArchivo(ruta, nodoRaiz);
        }

        public List<Personas> CargarTodo(string ruta)
        {
            return dal.CargarDatos(ruta);
        }

        public void VerificarUsuario(Personas persona, string ruta)
        {
           
            if (String.IsNullOrEmpty(persona.Nombre) || String.IsNullOrEmpty(persona.Cedula.ToString() )|| String.IsNullOrEmpty(persona.Clave.ToString()))
                
            {
                throw new Exception("Datos personales requeridos.");
            }
            else 
            {
                dal.AñadirPersona(persona, ruta);
            }
        }

    }
}
