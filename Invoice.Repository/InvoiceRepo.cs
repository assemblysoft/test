using BlazorApp.Shared;

namespace Invoice.Repository
{
    public class InvoiceRepo : IInvoiceRepo
    {
        public List<XInvoice> GetInvoices()
        {
            //return a mock invoice
            return new List<XInvoice>() { new() { Date = DateTime.Now } };
        }
    }
}
