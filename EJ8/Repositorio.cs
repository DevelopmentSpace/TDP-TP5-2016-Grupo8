using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ8
{
    /// <summary>
    /// Implementacion de IRepositorioUsuarios usando ListaDeUsuario
    /// </summary>
    public class Repositorio : IRepositorioUsuarios
    {
        IList<Usuario> iUsuarios = new List<Usuario> { };

        /// <summary>
        /// Agrega un usuario al repositorios
        /// </summary>
        /// <param name="pUsuario">Usuario a agregar</param>
        public void Agregar(Usuario pUsuario)
        {
            iUsuarios.Add(pUsuario);
        }

        /// <summary>
        /// Actualizar un usuario del repositorio
        /// </summary>
        /// <param name="pUsuario">Usuario actualizado</param>
        public void Actualizar(Usuario pUsuario)
        {
            iUsuarios.Remove(pUsuario);
            iUsuarios.Add(pUsuario);
        }

        /// <summary>
        /// Elimina un usuario
        /// </summary>
        /// <param name="pCodigo">Codigo del usuario</param>
        public void Eliminar(string pCodigo)
        {
            Usuario unUsuario = new Usuario();
            unUsuario.Codigo = pCodigo;
            if (!iUsuarios.Remove(unUsuario))
                throw new KeyNotFoundException();
        }
        
        /// <summary>
        /// Obtiene todas las cuentas en el repositorio
        /// </summary>
        /// <returns>Lista con todos los usuarios</returns>
        public IList<Usuario> ObtenerTodos()
        {
            return iUsuarios;
        }

        /// <summary>
        /// Obtiene por codigo un usuario
        /// </summary>
        /// <param name="pCodigo">Codigo del usuario</param>
        /// <returns>Usuario encontrado</returns>
        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            Usuario unUsuario = new Usuario();
            unUsuario.Codigo = pCodigo;
            return iUsuarios.ElementAt(iUsuarios.IndexOf(unUsuario));
        }

        /// <summary>
        /// Obtiene todos los usuarios ordenados segun un comparador.
        /// </summary>
        /// <param name="pComparador">Comparador con el que se hara la busqueda</param>
        /// <returns>Lista ordenada segun el comparador</returns>
        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            return iUsuarios.OrderBy( unUsuario => unUsuario ,pComparador).ToList();
        }

        /// <summary>
        /// Obtiene todos los usuarios que se aproximen a una cadena.
        /// </summary>
        /// <param name="pNombreCompleto">Nombre y apellido a aproximarse</param>
        /// <returns>Lista con todos los usuarios que se aproximan</returns>
        public IList<Usuario> ObtenerPorAproximacion(string pNombreCompleto)
        {
            List<Usuario> listaAprox = new List<Usuario> { };

            IEnumerator<Usuario> enumerador = iUsuarios.GetEnumerator();
            
            while (enumerador.MoveNext() )
            {
                if (enumerador.Current.NombreCompleto.StartsWith(pNombreCompleto))
                {
                    listaAprox.Add(enumerador.Current.Copy());
                }
            }

            return listaAprox;

        }

        /// <summary>
        /// Obtiene el ultimo codigo del usuario.
        /// </summary>
        /// <returns>Codigo del ultimo usuario, mas 1.</returns>
        public int ultimoCodigo()
        {
            if (iUsuarios.Count() == 0)
            {
                return 0;
            }
            else { 
                int ultimoCodigo;
                int.TryParse(iUsuarios.Last().Codigo, out ultimoCodigo);

                return ultimoCodigo + 1;
            }
        }

    }


    /// <summary>
    /// Clase para ordenar usuarios por nombre descendiente.
    /// </summary>
    public class OrdenarPorNombreDesc : IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            return String.Compare(x.NombreCompleto, y.NombreCompleto);
        }
    }

    /// <summary>
    /// Clase para ordenar usuarios por nombre ascendiente.
    /// </summary>
    public class OrdenarPorNombreAsc : IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            return -String.Compare(x.NombreCompleto, y.NombreCompleto);
        }
    }

    /// <summary>
    /// Clase para ordenar usuarios por correo electronico.
    /// </summary>
    public class OrdenarPorCorreoElectronicoDesc : IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            return String.Compare(x.CorreoElectronico, y.CorreoElectronico);
        }
    }







}
