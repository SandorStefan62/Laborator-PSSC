namespace app.components
{
    public record Comanda
    {
        public Contact? Contact { get; init; }
        public List<Produs> Produs { get; set; } = new List<Produs>();

        public void AdaugaComanda(Produs Produs)
        {
            Produs.Add(Produs);
        }
    }
}