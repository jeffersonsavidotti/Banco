using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco
{
    private static void Teste1()
    {
        Agencia agenciaAraraquara = new Agencia();
        agenciaAraraquara.Numero = 34;

        //Criar o primeiro Cliente com sua respectiva Conta (e Agencia)

        Cliente cliente1 = new Cliente();
        cliente1.Nome = "Thalita";
        cliente1.Documento ="999.999.999-99";

        //Exemplo de criação de variavel auxiliar para relacionar a Conta
        Conta contaCliente1 = new Conta();
        contaCliente1.Numero = "00001-0";
        contaCliente1.Agencia = agenciaAraraquara;
        cliente1.Conta = contaCliente1;

        //Criar o primeiro Cliente com sua respectiva Conta (e Agencia)
        Cliente cliente2 = new Cliente();
        cliente2.Nome = "Jefferson";
        cliente2.Documento ="888.888.888-88";

        //Exemplo sem criação de variavel auxiliar para relacionar a Conta
        cliente2.Conta = new Conta();
        cliente2.Conta.Numero = "00002-0";
        cliente2.Conta.Agencia = agenciaAraraquara;
        //900 de saldo
        cliente1.Depositar(1000);
        cliente1.Sacar(100);

        cliente2.Depositar(500);
        cliente2.Sacar(400);
        //100 de saldo

        cliente1.Transferir(900, cliente2.Conta);
        //Cliente 1 Transfere 900 para Cliente 2
        //Cliente 1 fica com Saldo 0
        //Cliente 2 fica com Saldo 1000

        //Imprimir Extratos
        cliente1.ImprimirExtrato;
        cliente2.ImprimirExtrato;


    }
}