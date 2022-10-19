namespace BibliotecaApi.Models
{
    public class Loan
    {

        public DateTime LoanStart { get; set; }
        public DateTime LoanEnd { get; set; }
        public Client Client { get; set; }
        
        public Book Book { get; set; }
    }
}
