using CursoDesignPatterns.App.PatternsStruture.Proxy.Interfaces;
using CursoDesignPatterns.App.PatternsStruture.Proxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.App.PatternsStruture.Proxy
{
    internal class VPN : IProxy
    {
        public void AcessarVPN(User user)
        {
            Console.WriteLine("Acessando a VPN");
            Thread.Sleep(2500);
            Console.WriteLine($"{user.Username} está conectado na VPN");
        }
    }
}
