﻿using CajaFuerteArduinoENL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Windows.Forms;


namespace CajaFuerteArduinoDAL
{
    public class PersonasDAL
    {
        private string rutaXML;
        private XmlDocument doc;

        public PersonasDAL()
        {
            doc = new XmlDocument();
        }

        public void CrearArchivo(string ruta, string nodoRaiz)
        {
            try
            {
                this.rutaXML = ruta;
                if (!File.Exists(rutaXML))
                {
                    XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                    XmlNode root = doc.DocumentElement;
                    doc.InsertBefore(xmlDeclaration, root);

                    XmlNode element1 = doc.CreateElement(nodoRaiz);
                    doc.AppendChild(element1);
                    doc.Save(ruta);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear el archivo xml."+e);
            }
        }

        public void AñadirPersona(Personas persona, string ruta)
        {
            try
            {
                if (!VerificarSiEsta(persona.Cedula.ToString(), ruta))
                {
                    if (!VerificarClave(persona.Clave, ruta))
                    {
                        rutaXML = ruta;
                        doc.Load(rutaXML);

                        XmlNode person = CrearPersona(persona);

                        XmlNode nodoRaiz = doc.DocumentElement;

                        nodoRaiz.InsertAfter(person, nodoRaiz.LastChild);

                        doc.Save(rutaXML);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        private XmlNode CrearPersona(Personas personas)
        {
            try
            {
                XmlNode usuario = doc.CreateElement("Datosusuario");

                XmlElement xCed = doc.CreateElement("cedula");
                xCed.InnerText = personas.Cedula.ToString();
                usuario.AppendChild(xCed);

                XmlElement xNom = doc.CreateElement("nombre");
                xNom.InnerText = personas.Nombre;
                usuario.AppendChild(xNom);

                XmlElement xClave = doc.CreateElement("clave");
                xClave.InnerText = personas.Clave.ToString();
                usuario.AppendChild(xClave);

                XmlElement xEstado = doc.CreateElement("estado");
                xEstado.InnerText = personas.Estado.ToString();
                usuario.AppendChild(xEstado);

                XmlElement xFecha = doc.CreateElement("fecha");
                xFecha.InnerText = personas.Fecha.ToString();
                usuario.AppendChild(xFecha);

                XmlElement xTipo = doc.CreateElement("tipo");
                xTipo.InnerText = personas.Tipo.ToString();
                usuario.AppendChild(xTipo);

                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear usuario."+ex);
            }
        }

        public bool VerificarClave(int clave, string ruta)
        {
            try
            {
                rutaXML = ruta;
                doc.Load(rutaXML);

                XmlNode personas = doc.DocumentElement;

                XmlNodeList listaPersonas = doc.SelectNodes("usuario/Datosusuario");

                foreach (XmlNode item in listaPersonas)
                {
                    if (item.SelectSingleNode("clave").InnerText.Equals(clave.ToString()))
                    {
                        throw new Exception("Clave invalida.");
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool VerificarSiEsta(string cedula, string ruta)
        {
            bool valor = false;
            try
            {
                rutaXML = ruta;
                doc.Load(rutaXML);

                XmlNode personas = doc.DocumentElement;

                XmlNodeList listaPersonas = doc.SelectNodes("usuario/Datosusuario");

                foreach (XmlNode item in listaPersonas)
                {
                    if (item.SelectSingleNode("cedula").InnerText.Equals(cedula))
                    {
                        valor = true;
                        //throw new Exception("El usuario ya existe.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw new Exception(ex.Message);
            }
            return valor;
        }
        public List<Personas> CargarDatos(string ruta)
        {
            try
            {
                List<Personas> personas = new List<Personas>();
                personas.Clear();
                Personas persona;
                rutaXML = ruta;
                doc.Load(rutaXML);

                XmlNodeList listaUsuarios = doc.SelectNodes("usuario/Datosusuario");

                XmlNode usuarios;

                for (int i = 0; i < listaUsuarios.Count; i++)
                {
                    persona = new Personas();
                    usuarios = listaUsuarios.Item(i);
                    persona.Cedula = Convert.ToInt32(usuarios.SelectSingleNode("cedula").InnerText);
                    persona.Nombre = usuarios.SelectSingleNode("nombre").InnerText;
                    persona.Clave = Int32.Parse(usuarios.SelectSingleNode("clave").InnerText);
                    persona.Estado = usuarios.SelectSingleNode("estado").InnerText;
                    persona.Fecha = usuarios.SelectSingleNode("fecha").InnerText;
                    persona.Tipo = usuarios.SelectSingleNode("tipo").InnerText;
                    personas.Add(persona);
                }
                return personas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar usuarios."+ex);
            }
        }

        public Label modificarPersona(Personas persona, string archivo)
        {
            Label mensaje = new Label();
            doc.Load(archivo);

            XmlElement datosPersona = doc.DocumentElement;

            XmlNodeList listaPersona = doc.SelectNodes("usuario/Datosusuario");

            XmlNode nueva_Persona = CrearPersona(persona);

            foreach (XmlNode item in listaPersona)
            {
                if (item.FirstChild.InnerText == Convert.ToString(persona.Cedula))
                {
                    XmlNode nodoOld = item;
                    datosPersona.ReplaceChild(nueva_Persona, nodoOld);

                }
            }
            doc.Save(archivo);
            mensaje.Text = "Se modifico con exito";
            return mensaje;
            //MessageBox.Show("Se modifico con exito", "EDICION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string VerificarUser(Personas persona, string ruta)
        {
            string valor = "";
            string tipo = "";
            try
            {
                rutaXML = ruta;
                doc.Load(rutaXML);

                XmlNode personas = doc.DocumentElement;

                XmlNodeList listaPersonas = doc.SelectNodes("usuario/Datosusuario");

                foreach (XmlNode item in listaPersonas)
                {
                    if (item.SelectSingleNode("cedula").InnerText == Convert.ToString(persona.Cedula) && item.SelectSingleNode("clave").InnerText == Convert.ToString(persona.Clave))
                    {
                            tipo = item.SelectSingleNode("tipo").InnerText;
                    }
                }

                if (tipo.Equals("T"))
                {
                    valor = "A";
                }
                else if (tipo.Equals("U"))
                {
                    valor = "U";
                }
                else if(tipo.Equals(""))
                {
                    valor = "N";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(""+e , "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return valor;
        }

        public bool VerificarEstado(String cedula, string ruta)
        {
            bool valor = false;
            string estado;
            try
            {
                rutaXML = ruta;
                doc.Load(rutaXML);

                XmlNode personas = doc.DocumentElement;

                XmlNodeList listaPersonas = doc.SelectNodes("usuario/Datosusuario");

                foreach (XmlNode item in listaPersonas)
                {
                    if (item.SelectSingleNode("cedula").InnerText.Equals(cedula)) 
                    {
                        estado = item.SelectSingleNode("estado").InnerText;
                        if (estado.Equals("Activo"))
                        {
                            valor = true;
                        }
                        else
                        {
                            valor = false;
                        }
                         
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return valor;
        }

        public void RegistrarIntento(Personas datos, string fecha, string hora, string ruta)
        {
            doc.Load(ruta);

            XmlNode intento = CrearIntento(datos, fecha, hora);

            XmlNode nodoRaiz = doc.DocumentElement;

            nodoRaiz.InsertAfter(intento, nodoRaiz.LastChild);

            doc.Save(ruta);
        }

        public XmlNode CrearIntento(Personas datos, string fecha, string hora)
        {
            XmlNode intento = doc.CreateElement("Intento_User");

            XmlElement id = doc.CreateElement("ID");
            id.InnerText = datos.Cedula.ToString();
            intento.AppendChild(id);

            XmlElement date = doc.CreateElement("DATE");
            date.InnerText = fecha;
            intento.AppendChild(date);

            XmlElement time = doc.CreateElement("TIME");
            time.InnerText = hora;
            intento.AppendChild(time);

            return intento;
        }
    }  
}