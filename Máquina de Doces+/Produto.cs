using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Máquina_de_Doces_
{
    class Produto
    {
        //Definição das variáveis
        private int codigo;
        private string nome; 
        private string descricao;
        private double preco;
        private int quantidade;
        private DateTime dtValidade;
        private Boolean situacao;

        //Método Construtor
        public Produto()
        {
            ModificarCodigo = 0;
            ModificarNome = "";
            ModificarDescricao = "";
            ModificarPreco = 0;
            ModificarQuantidade = 0;
            ModificarDataValidade = new DateTime();//0000/00/00 00:00:00
            ModificarSituacao = false;
        }//fim do método construtor


        public Produto(int codigo, string nome, string descricao, double preco, int quantidade, DateTime dtValidade, Boolean situacao)
        {
            ModificarCodigo = codigo;
            ModificarNome = nome;
            ModificarDescricao = descricao;
            ModificarPreco = preco;
            ModificarQuantidade = quantidade;
            ModificarDataValidade = dtValidade;
            ModificarSituacao = situacao;
        }//fim do método construtor com parãmetros

        //Métodos Get e Set
        //Métodos de acesso e modificação
        public int ModificarCodigo
        { 
            get{ 
                return this.codigo;
            }//fim do get - retornar o codigo   

            set{
                this.codigo = value;
            }//fim do set - modificar o código
        }//fim do ModificarCodigo

        public string ModificarNome
        {
            get { return this.nome;
            }//fim do get - retornar o codigo

            set { this.nome = value;
            }//fim do set - modificar o codigo
        }//fim do Modificar Nome
        
        public string ModificarDescricao
        {
            get { return this.descricao;
            }//fim do get - retornar o codigo

            set { this.descricao = value;
            }//fim do set - modificar o codigo
        }//fim do Modificar Descrição

        public double ModificarPreco
        {
            get { return this.preco;
            }//fim do get - retornar o codigo

            set { this.preco = value;
            }//fim do set - modificar o codigo
        }//fim do Modificar Preço

        public int ModificarQuantidade
        {
            get { return this.quantidade;
            }//fim do get - retornar o codigo

            set { this.quantidade = value;
            }//fim do set - modificar o codigo
        }//fim do Modificar Quantidade

        public DateTime ModificarDataValidade
        {
            get { return this.dtValidade;
            }//fim do get - retornar o codigo

            set { this.dtValidade = value;
            }//fim do set - modificar o codigo
        }//fim do Modificar Data de Validade

        public Boolean ModificarSituacao
        {
            get { return this.situacao;
            }//fim do get - retornar o codigo

            set { this.situacao = value;
            }//fim do set - modificar o codigo
        }//fim do Modificar Situação

        //Método Cadastrar Produto
        public void CadastrarProduto(int codigo, string nome, string descricao, double preco, int quantidade, DateTime dtValidade, Boolean situacao)
        {
            ModificarCodigo = codigo;
            ModificarNome = nome; 
            ModificarDescricao = descricao;
            ModificarPreco = preco;
            ModificarQuantidade = quantidade;
            ModificarDataValidade = dtValidade;
            ModificarSituacao = situacao;
        }//fim do método Cadastar Produto

        //Método Consultar Produto
        public string ConsultarProduto()
        {
            string msg = "";//Criando uma variável local

            if(ModificarCodigo == codigo)
            {
                 msg = "\nCódigo: " + ModificarCodigo +
                       "\nNome: " + ModificarNome +
                       "\nDescricão: " + ModificarDescricao +
                       "\nPreço: " + ModificarPreco +
                       "\nQuantidade: " + ModificarQuantidade +
                       "\nData de Validade: " + ModificarDataValidade +
                       "\nSituação: " + ModificarSituacao;
            }
            else
            {
                msg = "O código digitado não existe!";
            }

            return msg;
        }//fim do método Consultar Produto

        //Método atualizar Produto
        public Boolean AtualizarProduto(int codigo, int campo, string novoDado)
        {
            Boolean flag = false;

            if(ModificarCodigo == codigo)
            {
                switch(campo)
                {
                    case 1:
                        ModificarNome = novoDado;
                        flag = true;
                        break;
                    case 2:
                        ModificarDescricao = novoDado;
                        flag = true;
                        break;
                    case 3:
                        ModificarPreco = Convert.ToDouble(novoDado);
                        flag = true;
                        break;
                    case 4:
                        ModificarQuantidade = Convert.ToInt32(novoDado);
                        flag = true;
                        break;
                    case 5:
                        ModificarDataValidade = Convert.ToDateTime(novoDado);
                        flag = true;
                        break;
                    case 6:
                        ModificarSituacao = Convert.ToBoolean(novoDado);
                        flag = true;
                        break;
                    default:
                        break;
                }//fim do escolha
                return flag;
            }//fim do If
            return flag;
        }//fim do método Atualizar Produto

        //Método Desativar Produto

        //Método alterar Situacão
        public Boolean alterarSituacao(int codigo)
        {
            Boolean flag = false;

            if(ModificarCodigo == codigo)
            {
                if(ModificarSituacao == true)
                {
                    ModificarSituacao = false;
                }
                else
                {
                    ModificarSituacao = true;
                }//fim do modificar Situação
                flag = true;
            }//fim do modificar Codigo
            return flag;
        }//fim do Alterar Situação

        //SolicitarProdutos
        public Boolean SolicitarProduto(int codigo)
        {
            if(ModificarCodigo == codigo)
            {
                if (ModificarQuantidade <= 3)
                {
                    return true;
                }
            }//fim do if
            return false;
        }//fim Solicitar Produtos

    }//fim da classe
}//fim do projeto