﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ8
{
    public interface IRepositorioUsuarios
    {
        void Agregar(Usuario pUsuario);
        void Actualizar(Usuario pUsuario);
        void Eliminar(string pCodigo);
        IList<Usuario> ObtenerTodos();
        Usuario ObtenerPorCodigo(string pCodigo);
        IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador);
        IList<Usuario> ObtenerPorAproximacion(string pNombreCompleto);
        int ultimoCodigo();
    }
}
