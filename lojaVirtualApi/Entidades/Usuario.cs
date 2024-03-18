namespace lojaVirtualApi.Entidades
{
    public class Usuario
    {
        public string Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public Carrinho? Carrinho { get; set; }
    }
}
