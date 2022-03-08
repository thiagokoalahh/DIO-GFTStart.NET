using CsvHelper.Configuration.Attributes;

namespace csv_Helper.Model
{
    public class Livro
    {
        //[Name("titulo")]
        //[Index(0)]
        public string Titulo { get; set; }

        //[Name("preço")]
        //[Index(1)]
        //[CultureInfo("pt-BR")]
        public decimal Preco { get; set; }

        //[Name("autor")]
        //[Index(2)]
        public string Autor { get; set; }

        //[Name("lançamento")]
        //[Index(3)]
        //[Format("dd/MM/yyyy")]
        public DateOnly Lancamento { get; set; }
    }
}