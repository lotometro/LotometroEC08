using LotometroAPI.Interfaces;
using LotometroAPI.Repository;
using LotometroAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace LotometroAPI.Controllers
{
    [Route("api/[controller]")]
    public class MonitoringController : Controller
    {
        private readonly ICameraService _cameraService;

        public MonitoringController([FromServices] ICameraService cameraService)
        {
            _cameraService = cameraService;
        }

        [HttpGet, Route("GetList")]
        public IActionResult GetList()
        {
            return Ok(_cameraService.Get());
        }

        [HttpGet, Route("GetById/{id}")]
        public IActionResult GetById(string id)
        {
            return Ok(_cameraService.Get(id));
        }

        [HttpGet, Route("CalculateProdutorio/iterative/{m}/{n}")]
        public IActionResult CalculateProdutorioByIterative(int m, int n)
        {
            double produtorio = 1;

            for (int i = m; i <= n; i++)
            {
                produtorio *= i + ((double)1 / i);
            }

            return Ok(produtorio);
        }

        [HttpGet, Route("CalculateProdutorio/recursion/{m}/{n}")]
        public IActionResult CalculateProdutorioByRecursion(int m, int n)
        {
            return Ok(CalculateProdutorio(m, n));
        }

        public double CalculateProdutorio(int m, int n)
        {
            double produtorio = 1;


            if (m <= n)
                produtorio *= (m + ((double)1 / m)) * CalculateProdutorio(++m, n);

            return produtorio;
        }

    }
}
