using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Dominio;

namespace Sistema.Repositorio
{
    public interface IAlunoRepositorio
    {
        void Adicionar(Aluno aluno);
        List<Aluno> Listar();
        void Atualizar(Aluno aluno);
        void Remover(int id);

    }
}
