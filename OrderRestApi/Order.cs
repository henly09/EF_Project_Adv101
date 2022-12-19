namespace OrderRestApi
{
    public class Order
    {
        public int ID { get; set; }

        public int price { get; set; } = 0;

        public string ordered { get; set; } = string.Empty;

        public int pieces { get; set; } = 0;

        public string Type_ { get; set; } = string.Empty;

        public string orderdate { get; set; } = string.Empty;

        public string ordertime { get; set; } = string.Empty;

        public string fullname { get; set; } = string.Empty;

        public string email { get; set; } = string.Empty;

        public string phonenumber { get; set; } = string.Empty;

        public string address { get; set; } = string.Empty;


    }
}
