using System;

namespace Dio.Series.Classes
{
    public class Serie : Base
    {
        private GeneroEnum Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Ativo { get; set; }     

        public Serie(int id, GeneroEnum genero, string titulo, string descricao, int ano)
        {
            this.Id = Id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Ativo = true;
        }

        public override string ToString()
        {
            string valoresPropriedades
             = "Gênero: " + this.Genero + Environment.NewLine;
            valoresPropriedades
             += "Título: " + this.Titulo + Environment.NewLine;
            valoresPropriedades
             += "Descrição: " + this.Descricao + Environment.NewLine;
            valoresPropriedades
             += "Ano: " + this.Ano + Environment.NewLine;

            return valoresPropriedades;

        }

        public string getTitulo() {
            return this.Titulo;
        }

        public int getId() {
            return this.Id;
        }

        public void setAtivo() {
            this.Ativo = false;
        }

        public bool getAtivo() {
            return this.Ativo;
        }

    }
}