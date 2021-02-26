using CadastroDeSeries.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroDeSeries.Classes
{
    public class Serie : EntidadeBase
    {
        //Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }
        //Métodos
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }
        public override string ToString()
        {
            string retorno = "";
            retorno += $"Gênero: {Genero}{Environment.NewLine}";
            retorno += $"Título: {Titulo}{Environment.NewLine}";
            retorno += $"Descrição: {Descricao}{Environment.NewLine}";
            retorno += $"Ano de Início: {Ano}{Environment.NewLine}";
            retorno += $"Excluído: {(Excluido?"Sim":"Não")}";
            return retorno;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        } 
        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaId()
        {
            return this.Id;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}
