using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET5_first_web_example.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
