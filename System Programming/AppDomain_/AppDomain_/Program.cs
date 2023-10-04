using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(AppDomain.CurrentDomain);
            //Console.WriteLine(AppDomain.CurrentDomain.FriendlyName);
            PermissionSet permission = new PermissionSet
                (System.Security.Permissions.PermissionState.Unrestricted);
            permission.AddPermission(
                new FileIOPermission(FileIOPermissionAccess.NoAccess, @"c:\"));
            var appSetup = new AppDomainSetup() { ApplicationBase = Environment.CurrentDirectory};
            var domain = AppDomain.CreateDomain("My Super Secure Domain", null, appSetup, permission);
            var type = typeof(BadProgram);
            //Console.WriteLine(type.Assembly.FullName);
            domain.CreateInstance(type.Assembly.FullName, type.FullName);
            //var some = type.GetMethod("SomeFoo");
            //foreach (var item in some.GetParameters())
            //{
            //    Console.WriteLine(item.ParameterType.FullName);
            //}

            //BadProgram badProgram = new BadProgram();
            
        }
    }

    class BadProgram
    {
        public BadProgram()
        {
            Console.WriteLine("Xatker program. Xa xa xa. Astalavista");
        }
        public void SomeFoo(string a, int b)
        {
            Console.WriteLine("Some Operations");
        }
        ~BadProgram()
        {
            Console.WriteLine("Ya ukrast vash danniy. Ves vash danniy");
        }
    }
}
