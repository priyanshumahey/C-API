using System.Collections.Generic;
using HelloWorld.Models;

namespace HelloWorld.Data
{
    public interface IHelloWorldRepo
    {
        IEnumerable<Hello> GetAppCommands();
    }
}