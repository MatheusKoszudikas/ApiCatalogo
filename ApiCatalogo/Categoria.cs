using System.Collections.ObjectModel;

namespace ApiCatalogo;

public class Categoria
{

    public Categoria()
    {
       Produtos = new Collection<Produto>();
    }  
    public int CatoriaId { get; set; }

    public string? Nome { get; set; }

    public string? ImagemUrl { get; set; }

    public ICollection<Produto>?Produtos { get; set; }
}
