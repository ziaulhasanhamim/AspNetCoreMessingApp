using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Application
{
    public interface IChatClient
    {
        Task ReceiveMessage(string user, string message);
    }
}
