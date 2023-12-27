using CursoDesignPatterns.App.PatternsStruture.Proxy.Interfaces;
using CursoDesignPatterns.App.PatternsStruture.Proxy.Model;
using CursoDesignPatterns.App.PatternsStruture.Proxy.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.App.PatternsStruture.Proxy
{
    internal class VPNProxy : IProxy
    {
        public void AcessarVPN(User user)
        {
            DataBaseConnection sql = new();
            sql.RegistrarAcessoVPN(user);
            Console.WriteLine(new string('-', 40));

            VPN vpn = new();
            vpn.AcessarVPN(user);
        }
    }
}
