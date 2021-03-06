using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        
        private int Temporada { get; set; }
        private int QuantidadeEpisodio { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano, int temporada, int quantidadeEpisodio)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Temporada = temporada;
            this.QuantidadeEpisodio = quantidadeEpisodio;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Temporada: " + this.Temporada + Environment.NewLine;
            retorno += "Numéro de episodios: " + this.QuantidadeEpisodio + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }
    }
}