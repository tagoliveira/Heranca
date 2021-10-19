using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pessoa obj_pessoa = new Pessoa();
            //obj_pessoa.nome = "Thiago A G Oliveira";
            //obj_pessoa.fone = "99999999999";

            PessoaFisica obj_pf = new PessoaFisica();
            obj_pf.apelido = "aaaaa";
            obj_pf.nome = "Thiago A G Oliveira";
            obj_pf.fone = "99999999999";
            obj_pf.cpf = "34234234";
            obj_pf.endereco = "dsafkdsjfçsadjf";
            obj_pf.idade = 34;

            PessoaJuridica obj_pj = new PessoaJuridica();
            obj_pj.nome = "Thiago";
            obj_pj.nome_fantasia = "CoolerInformatica";

        }
    }
}
