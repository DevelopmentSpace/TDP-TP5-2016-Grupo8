using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ8
{
    /// <summary>
    /// Clase de control de facha de un repositorio
    /// </summary>
    class FachadaRepositorio
    {

        IRepositorioUsuarios repositorio = new Repositorio();

        /// <summary>
        /// Agrega un usuario al repositorio
        /// </summary>
        /// <param name="pNombreYApellido">Nombre y apellido</param>
        /// <param name="pCorreoElectronico">Correo electronico</param>
        public void agregarUsuario(string pNombreYApellido,string pCorreoElectronico)
        {
            Usuario nuevoUsuario = new Usuario();
            nuevoUsuario.Codigo = repositorio.ultimoCodigo().ToString();
            nuevoUsuario.NombreCompleto = pNombreYApellido;
            nuevoUsuario.CorreoElectronico = pCorreoElectronico;

            repositorio.Agregar(nuevoUsuario);
        }

        /// <summary>
        /// Modifica un usuario del repositorio.
        /// </summary>
        /// <param name="pCodigo">Codigo</param>
        /// <param name="pNombreYApellido">Nombre y apellido</param>
        /// <param name="pCorreoElectronico">Correo electronico</param>
        public void actualizarUsuario(string pCodigo,string pNombreYApellido, string pCorreoElectronico)
        {
            Usuario nuevoUsuario = new Usuario();
            nuevoUsuario.Codigo = pCodigo;
            nuevoUsuario.NombreCompleto = pNombreYApellido;
            nuevoUsuario.CorreoElectronico = pCorreoElectronico;

            repositorio.Actualizar(nuevoUsuario);
        }

        /// <summary>
        /// Elimina un usuario del repositorio
        /// </summary>
        /// <param name="pCodigo">Codigo</param>
        public void eliminarUsuario(string pCodigo)
        {
            repositorio.Eliminar(pCodigo);
        }

        /// <summary>
        /// Obtiene un usuario por codigo
        /// </summary>
        /// <param name="pCodigo">Codigo</param>
        /// <returns></returns>
        public Dictionary<string,string> obtenerPorCodigo(string pCodigo)
        {
            Dictionary<string, string> formatoUsuario = new Dictionary<string, string> { };
            Usuario usuarioEncontrado = repositorio.ObtenerPorCodigo(pCodigo);
            formatoUsuario.Add("NombreYApellido", usuarioEncontrado.NombreCompleto);
            formatoUsuario.Add("CorreoElectronico", usuarioEncontrado.CorreoElectronico);

            return formatoUsuario;
            
        }

        /// <summary>
        /// Obtiene una lista de todos los usuario
        /// </summary>
        /// <returns>Lista con diccionario que contiene los datos del usuario</returns>
        public IList<Dictionary<string,string>> obtenerTodos()
        {
            IList<Dictionary<string, string>> listaUsuarios = new List<Dictionary<string, string>> { };
            foreach (Usuario usua in repositorio.ObtenerTodos())
            {
                Dictionary<string, string> usuarioDiccionario = new Dictionary<string, string> { };
                usuarioDiccionario.Add("Codigo", usua.Codigo);
                usuarioDiccionario.Add("NombreYApellido", usua.NombreCompleto);
                usuarioDiccionario.Add("CorreoElectronico", usua.CorreoElectronico);
                listaUsuarios.Add(usuarioDiccionario);
            }
            return listaUsuarios;
        }

        /// <summary>
        /// Obtiene una lista de todos los usuario que se aproximan a la cadena
        /// </summary>
        /// <param name="pCadena">cadena de busqueda</param>
        /// <returns>Lista de diccionario de usuarios con sus respectivos datos.</returns>
        public IList<Dictionary<string, string>> obtenerPorAproximacion(string pCadena)
        {
            IList<Dictionary<string, string>> listaUsuarios = new List<Dictionary<string, string>> { };
            foreach (Usuario usua in repositorio.ObtenerPorAproximacion(pCadena))
            {
                Dictionary<string, string> usuarioDiccionario = new Dictionary<string, string> { };
                usuarioDiccionario.Add("Codigo", usua.Codigo);
                usuarioDiccionario.Add("NombreYApellido", usua.NombreCompleto);
                usuarioDiccionario.Add("CorreoElectronico", usua.CorreoElectronico);
                listaUsuarios.Add(usuarioDiccionario);
            }
            return listaUsuarios;
        }

        /// <summary>
        /// Obtiene una lista de todos los usuarios ordenados por un comparador
        /// </summary>
        /// <param name="pCadena">Nombre comparador</param>
        /// <returns>Lista de diccionario de usuarios con sus respectivos datos ordenados segun el comparador.</returns>
        public IList<Dictionary<string, string>> obtenerOrdenadosPor(string pComparador)
        {
            IList<Dictionary<string, string>> listaUsuarios = new List<Dictionary<string, string>> { };
            IComparer<Usuario> comparador;
            switch (pComparador)
            {
                case "NombreDescendente":
                    {
                        comparador = new OrdenarPorNombreDesc();
                        break;
                    }
                case "CorreoDescendente":
                    {
                        comparador = new OrdenarPorCorreoElectronicoDesc();
                        break;
                    }
                default:
                    {
                        comparador = new OrdenarPorNombreAsc();
                        break;
                    }
            }
            foreach (Usuario usua in repositorio.ObtenerOrdenadosPor(comparador))
            {
                Dictionary<string, string> usuarioDiccionario = new Dictionary<string, string> { };
                usuarioDiccionario.Add("Codigo", usua.Codigo);
                usuarioDiccionario.Add("NombreYApellido", usua.NombreCompleto);
                usuarioDiccionario.Add("CorreoElectronico", usua.CorreoElectronico);
                listaUsuarios.Add(usuarioDiccionario);
            }
            return listaUsuarios;
        }

        /// <summary>
        /// Obtiene el codigo del ultimo usuario en la lista del repositorio
        /// </summary>
        /// <returns>Codigo del ultimo usuario del repositorio.</returns>
        public int ultimoCodigo()
        {
            return repositorio.ultimoCodigo();
        }
    }
}
