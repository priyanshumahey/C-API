using System.Collections.Generic;
using HelloWorld.Models;

namespace HelloWorld.Data
{
    public class MockHelloWorldRepo : IHelloWorldRepo
    {
        public IEnumerable<Hello> GetAppCommands()
        {
            var Hello = new List<Hello>
            {
                new Hello{Message= "Hello World"}
            };

            return Hello;
        
        }
    }
}