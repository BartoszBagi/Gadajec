using MediatR;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;

namespace Gadajec.Server.Controllers
{
    public class ApiControllerBase : Controller
    {        
            private ISender _mediator;
            protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetService<ISender>();
        
    }
}
