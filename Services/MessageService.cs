using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDependenciaWinForms.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Ola Windows form!";
        }
    }
}
