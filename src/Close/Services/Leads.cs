using Close.Models.Leads;

namespace Close.Services;

public class Leads : Service<Lead>
{
    public Leads(CloseClient closeClient) : base(closeClient, "lead")
    {
    }
}