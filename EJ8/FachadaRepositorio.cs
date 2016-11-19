using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ8
{
    class FachadaRepositorio
    {

        IRepositorioUsuarios repositorio = new Repositorio();

        public void agregarUsuario(string pNombreYApellido,string pCorreoElectronico)
        {
            Usuario nuevoUsuario = new Usuario();
            nuevoUsuario.Codigo = repositorio.ultimoCodigo().ToString();
            nuevoUsuario.NombreCompleto = pNombreYApellido;
            nuevoUsuario.CorreoElectronico = pCorreoElectronico;

            repositorio.Agregar(nuevoUsuario);
        }

        public void eliminarUsuario(string pCodigo)
        {
            repositorio.Eliminar(pCodigo);
        }

        public Dictionary<string,string> obtenerPorCodigo(string pCodigo)
        {
            Dictionary<string, string> formatoUsuario = new Dictionary<string, string> { };
            Usuario usuarioEncontrado = repositorio.ObtenerPorCodigo(pCodigo);
            formatoUsuario.Add("NombreYApellido", usuarioEncontrado.NombreCompleto);
            formatoUsuario.Add("CorreoElectronico", usuarioEncontrado.CorreoElectronico);

            return formatoUsuario;
            
        }

        public int ultimoCodigo()
        {
            return repositorio.ultimoCodigo();
        }
        //Aca habria que definir Crear usuario, Modificar usuario, todos esos.
    }
}
