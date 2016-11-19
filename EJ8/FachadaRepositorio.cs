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

        public void actualizarUsuario(string pCodigo,string pNombreYApellido, string pCorreoElectronico)
        {
            Usuario nuevoUsuario = new Usuario();
            nuevoUsuario.Codigo = pCodigo;
            nuevoUsuario.NombreCompleto = pNombreYApellido;
            nuevoUsuario.CorreoElectronico = pCorreoElectronico;

            repositorio.Actualizar(nuevoUsuario);
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

        public IList<Dictionary<string, string>> obtenerTodos(string pCadena)
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

        public int ultimoCodigo()
        {
            return repositorio.ultimoCodigo();
        }
    }
}
