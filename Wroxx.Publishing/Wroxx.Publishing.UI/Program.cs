using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Wroxx.Publishing.Domain;
using Wroxx.Publishing.Infrastructure;

namespace Wroxx.Publishing.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the unity container
            IUnityContainer container = new UnityContainer();

            container.RegisterType<IBook, BookManager>();

            var controller = container.Resolve<Author>();

            var x = controller.GetRepeatedWordInfo();

            // Print the result

            Parallel.ForEach(x,
                y => Console.WriteLine("{0} - {1} ", y.Key, y.Count()));


        }
    }
}
