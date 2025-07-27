using BlazorApp.Shared;
namespace Invoice.Repository
{

    public interface IInvoiceRepo
    {
        List<XInvoice> GetInvoices();
    }
}
