using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Produtos.Controllers 
{
    public class ProdutoController : Controller
    {
        
        public IActionResult Index()
        {
            
            List<string> nomesProdutos = new List<string> { "Teclado Mecânico", "Mouse Gamer", "Monitor 24'", "Fone de Ouvido", "Mousepad XL" };
            
            
            List<double> precosProdutos = new List<double> { 250.00, 85.50, 899.90, 150.00, 45.00 };

            
            ViewBag.ListaNomes = nomesProdutos;
            ViewBag.ListaPrecos = precosProdutos;

            return View();
        }
    }
}