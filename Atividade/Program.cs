using System;
namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
                Console.WriteLine("Informar Nome: ");
                string var_nome = Console.ReadLine();
                Console.WriteLine("Informar endereço: ");
                string var_endereco = Console.ReadLine();
                Console.WriteLine("Pessoa Física(f) ou Jurídica(j)? ");
                string var_tipo = Console.ReadLine();
                if (var_tipo == "f")
                {
                    // --- Pessoa Física ---
                    Pessoa_Fisica pf = new Pessoa_Fisica();
                    pf.nome = var_nome;
                    pf.endereco = var_endereco;
                    Console.WriteLine("Informe seu CPF: ");
                    pf.cpf = Console.ReadLine();
                    Console.WriteLine("Informe seu RG: ");
                    pf.rg = Console.ReadLine();
                    Console.WriteLine("Informe o Valor da Compra: ");
                    val_pag = float.Parse(Console.ReadLine());
                    pf.Pagar_Imposto(val_pag);
                    Console.WriteLine("----------- Pessoa Física ----------");
                    Console.WriteLine("Nome:..........:" + pf.nome);
                    Console.WriteLine("Endereço:......:" + pf.endereco);
                    Console.WriteLine("CPF............:" + pf.cpf);
                    Console.WriteLine("RG.............:" + pf.rg);
                    Console.WriteLine("Valor da Compra:" + pf.valor.ToString("C"));
                    Console.WriteLine("Imposto........:" + pf.valor_imposto.ToString("c"));
                    Console.WriteLine("Total a Pagar..:" + pf.total.ToString("C"));
                }
        }
    }
}