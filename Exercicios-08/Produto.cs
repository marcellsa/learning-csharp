// 3.Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de adicionar novos produtos, e exibir todos os produtos no estoque.
class Produto
{
    private double preco;
    private int estoque;
    public string Nome {get; set;}
    public string Marca {get; set;}
    public double Preco {
        get => preco; 
        set
        {
            if(value > 0)
                preco = value;
            else
                preco = 10;
        }
    }
    
    public int Estoque {
        get => estoque; 
        set 
        {
            if(value > 0)
                estoque = value;
            else
                estoque = 0;

        }
    }

    public string Descricao => $"{this.Nome} {this.Marca} - {this.Preco} - Quantidade: {this.Estoque}";

}