using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aluno.dominio;

namespace aluno.repositorio
{
    public interface IAlunorepositorio
    {
        void adicionar();
        List<int> listar();
    }
}
