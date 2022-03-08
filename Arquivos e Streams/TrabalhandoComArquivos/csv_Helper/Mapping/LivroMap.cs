using csv_Helper.Model;
using CsvHelper.Configuration;
using System.Globalization;

namespace csv_Helper.Mapping
{
    public class LivroMap : ClassMap<Livro>
    {
        public LivroMap()
        {
            Map(x => x.Titulo).Name("titulo");
            Map(x => x.Preco)
                .Name("preço")
                .TypeConverterOption
                .CultureInfo(CultureInfo.GetCultureInfo("pt-BR"));
            Map(x => x.Autor).Name("titulo");
            Map(x => x.Lancamento)
                .Name("lançamento")
                .TypeConverterOption
                .Format(new[] { "dd/MM/yyyy" });
        }
    }
}
