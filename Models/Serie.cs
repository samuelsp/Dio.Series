using System;
using Dio.Series.Models.Enums;

namespace Dio.Series.Models
{
    public class Serie : Base
    {
        public GeneroEnum Genero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public bool Ativo { get; set; }     
       
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

        

    }
}