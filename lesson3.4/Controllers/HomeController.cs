using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lesson3._4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.PrimeNumbers = GetPrimeNumbers();
            ViewBag.Factorials = GetFactorials();
            ViewBag.TimesTables = GetTimesTables();
            return View();
        }
        private List<int> GetPrimeNumbers()
        {
            List<int> primes = new List<int>();
            for (int i = 2; i <= 100; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(i);
                }
            }
            return primes;
        }

        private List<long> GetFactorials()
        {
            List<long> factorials = new List<long>();
            long factorial = 1;
            for (int i = 1; i <= 10; i++)
            {
                factorial *= i;
                factorials.Add(factorial);
            }
            return factorials;
        }

        private Dictionary<int, List<int>> GetTimesTables()
        {
            Dictionary<int, List<int>> timesTables = new Dictionary<int, List<int>>();
            for (int i = 2; i <= 9; i++)
            {
                List<int> table = new List<int>();
                for (int j = 1; j <= 10; j++)
                {
                    table.Add(i * j);
                }
                timesTables.Add(i, table);
            }
            return timesTables;
        }

        }
}