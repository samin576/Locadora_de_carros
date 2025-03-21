﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco
{
    class Veiculo : IVeiculo
    {

        List<Veiculo> VeiculosCadastrados = new List<Veiculo>();
        List<Veiculo> CarrosCadastrados = new List<Veiculo>();
        List<Veiculo> MotosCadastrados = new List<Veiculo>();
        List<Veiculo> CaminhoesCadastrados = new List<Veiculo>();
        private string _modelo;
        private string _marca;
        private int _ano;
        private double _valorBase;

        public Veiculo()
        {
        }
        public string Modelo
        { get { return _modelo; } set { _modelo = value; } }
        public string Marca
        { get { return _marca; } set { _marca = value; } }
        public int Ano
        { get { return _ano; } set { _ano = value; } }
        public double ValorBase
        { get { return _valorBase; } set { _valorBase = value; } }
        public void CadastrarVeiculo()
        {
            Veiculo novoVeiculo = new Veiculo();
            Console.WriteLine("""
                1 - Carro
                2 - Moto
                3 - Caminhão
                """);
            int escolha = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Qual é o modelo do veiculo?");
            novoVeiculo.Modelo = Console.ReadLine();
            Console.WriteLine("Qual é a marca?");
            novoVeiculo.Marca = Console.ReadLine();
            Console.WriteLine("Qual é o ano?");
            novoVeiculo.Ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o valor base dele?");
            novoVeiculo.ValorBase = double.Parse(Console.ReadLine());
            VeiculosCadastrados.Add(novoVeiculo);
            switch (escolha)
            {
                case 1:
                    CarrosCadastrados.Add(novoVeiculo);
                    break;
                case 2:
                    MotosCadastrados.Add(novoVeiculo);
                    break;
                case 3:
                    CaminhoesCadastrados.Add(novoVeiculo);
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            Console.WriteLine("Veículo cadastrado com sucesso!");
        }
        public void RemovaVeiculo()
        {
            if (VeiculosCadastrados.Count == 0)
            {
                Console.WriteLine("Você não tem nenhum veículo cadastrado, logo não tem como remover!");
            }
            else
            {
                Console.WriteLine("""
                1 - Carro
                2 - Moto
                3 - Caminhão
                """);
                int escolhaVeiculo = int.Parse(Console.ReadLine());
                switch (escolhaVeiculo)
                {
                    case 1:
                        for (int i = 0; i < CarrosCadastrados.Count; i++)
                        {
                            Console.WriteLine($"{i} - {CarrosCadastrados[i].Modelo} | Ano {CarrosCadastrados[i].Ano} ");
                        }
                        Console.WriteLine("Qual veículo deseja remover?");
                        int escolha = int.Parse(Console.ReadLine());
                        CarrosCadastrados.Remove(CarrosCadastrados[escolha]);
                        break;
                    case 2:
                        for (int i = 0; i < MotosCadastrados.Count; i++)
                        {
                            Console.WriteLine($"{i} - {MotosCadastrados[i].Modelo}  | Ano  {MotosCadastrados[i].Ano} ");
                        }
                        Console.WriteLine("Qual veículo deseja remover?");
                        int escolha2 = int.Parse(Console.ReadLine());
                        MotosCadastrados.Remove(MotosCadastrados[escolha2]);
                        break;
                    case 3:
                        for (int i = 0; i < CaminhoesCadastrados.Count; i++)
                        {
                            Console.WriteLine($"{i} - {CaminhoesCadastrados[i].Modelo} | Ano {CaminhoesCadastrados[i].Ano} ");
                        }
                        Console.WriteLine("Qual veículo deseja remover?");
                        int escolha3 = int.Parse(Console.ReadLine());
                        CaminhoesCadastrados.Remove(CaminhoesCadastrados[escolha3]);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("Veículo removido com sucesso!");
            }
        }
        public void ListarVeiculos()
        {
            if (VeiculosCadastrados.Count == 0)
            {
                Console.WriteLine("Você não tem nenhum veículo cadastrado!");
            }
            else
            {
                for (int i = 0; i < VeiculosCadastrados.Count; i++)
                {
                    Console.WriteLine($"{i} {VeiculosCadastrados[i].Modelo} | Marca {VeiculosCadastrados[i].Marca} | Ano {VeiculosCadastrados[i].Ano} | Valor Base {VeiculosCadastrados[i].ValorBase} reais");
                }
            }
        }
        public void FazerAluguel()
        {
            if (VeiculosCadastrados.Count == 0)
            {
                Console.WriteLine("Você não tem nenhum veículo cadastrado, logo não tem como fazer o aluguel!");
            }
            else
            {
                Console.WriteLine("""
                1 - Carro
                2 - Moto
                3 - Caminhão
                """);
                int escolhaVeiculo = int.Parse(Console.ReadLine());
                switch (escolhaVeiculo)
                {
                    case 1:
                        for (int i = 0; i < CarrosCadastrados.Count; i++)
                        {
                            Console.WriteLine($"{i} {CarrosCadastrados[i].Modelo} | Marca {CarrosCadastrados[i].Marca} | Ano {CarrosCadastrados[i].Ano} | Valor Base {CarrosCadastrados[i].ValorBase} reais");
                        }
                        Console.WriteLine("Qual carro deseja fazer o aluguel?");
                        int escolha = int.Parse(Console.ReadLine());
                        Carro veiculo = new Carro();
                        veiculo = CarrosCadastrados[escolha];
                        Console.WriteLine("Seriam para quantos dias?");
                        int dias = int.Parse(Console.ReadLine());
                        veiculo.CalcularAluguel(dias);
                        Console.WriteLine($"O total do aluguel é de {veiculo.CalcularAlukdguel(dias)}");
                        break;
                    case 2:
                        for (int i = 0; i < MotosCadastrados.Count; i++)
                        {
                            Console.WriteLine($"{i} {MotosCadastrados[i].Modelo} | Marca {MotosCadastrados[i].Marca} | Ano {MotosCadastrados[i].Ano} | Valor Base {MotosCadastrados[i].ValorBase} reais");
                        }
                        Console.WriteLine("Qual moto deseja fazer o aluguel?");
                        int escolha2 = int.Parse(Console.ReadLine());
                        Moto veiculo2 = new Moto();
                        veiculo2 = MotosCadastrados[escolha2];
                        Console.WriteLine("Seriam para quantos dias?");
                        int dias2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"O total do aluguel é de {veiculo2.CalcularAluguel(dias2)}");
                        break;
                    case 3:
                        for (int i = 0; i < CaminhoesCadastrados.Count; i++)
                        {
                            Console.WriteLine($"{i} {CaminhoesCadastrados[i].Modelo} | Marca {CaminhoesCadastrados[i].Marca} | Ano {CaminhoesCadastrados[i].Ano} | Valor Base {CaminhoesCadastrados[i].ValorBase} reais");
                        }
                        Console.WriteLine("Qual caminhão deseja fazer o aluguel?");
                        int escolha3 = int.Parse(Console.ReadLine());
                        Caminhao veiculo3 = new Caminhao();
                        veiculo3 = CaminhoesCadastrados[escolha3];
                        Console.WriteLine("Seriam para quantos dias?");
                        int dias3 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"O total do aluguel é de {veiculo3.CalcularAluguel(dias3)}");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.Clear();
                Console.WriteLine("Aluguel feito com sucesso");

            }
        }
        public void ResumoAluguel()
        {

        }
        public virtual double CalcularAluguel(int dias)
        {
            double totalDoAluguel = ValorBase * dias;
            return totalDoAluguel;
        }
    }
}