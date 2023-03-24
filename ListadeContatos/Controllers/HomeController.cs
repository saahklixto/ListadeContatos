using ListadeContatos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace ListadeContatos.Controllers
{
    public class HomeController : Controller
    { 


        public string Index()
        {
            SqlConnection Academia = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=samara;Integrated Security=True;");


            SqlCommand AcademiaCommand = new SqlCommand("Select * From Exercicios", Academia);
            string Treino = "";

            Academia.Open();
            var retorno = AcademiaCommand.ExecuteReader();
            while (retorno.Read())
            {
               Treino += retorno["series"].ToString() + "<br>";

            }
            
            
            
            
            
            
            
            Academia.Close();




            return Treino;

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}