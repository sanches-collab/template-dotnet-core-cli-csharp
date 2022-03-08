// See https://aka.ms/new-console-template for more information
namespace Dio.Series
{
    public class Serie:EntidadeBase
    {
        //Atributos
       private Genero Genero {get; set;} 
       private string Título {get; set;}
       private string Descriao {get; set;}
       private int Ano {get; set;}
       private bool Excluido {get; set;}

       //Métodos
       public Serie {Int id,Genero genero, string titulo, string descricao,int ano}
       {
       this.Id =id;
       this.Genero = genero;
       this.Titulo=titulo;
       this.Descriao=descricao;
       this.Ano=ano;
       this.Excluido=false;
       }
       public override string ToString()
       {
         //Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
           string retorno= "";
           retorno =+"Genero:" + this.Genero + Environment.NewLine;
           retorno =+ "Titulo:" + this.Titulo + Environment.NewLine;
           retorno =+ "Descricao:" + this.Descricao + Environment.NewLine;
           retorno =+ "Ano de Inicio:" + this.Ano + Environment.NewLine;
           retorno =+
       }
       public string retornaTitulo()
       {
           return this.Titulo;
       }

       public interface retornaId()
       {
           return this.Id;
       }

       public void Excluir(){
           this.Excluido=true;
       }
    }
}