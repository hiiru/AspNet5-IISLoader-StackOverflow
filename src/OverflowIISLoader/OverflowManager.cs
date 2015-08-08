using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;

namespace OverflowIISLoader
{
    public class OverflowManager
    {
        private readonly HttpContext _context;
        public OverflowManager(IHttpContextAccessor context)
        {
            _context = context.HttpContext;
        }
        
        public void CreateStackOverflow()
        {
            var x =_context.RequestAborted;
        }
    }
}