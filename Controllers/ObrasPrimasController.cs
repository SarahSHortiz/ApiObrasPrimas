using ApiObrasPrimas.DAO;
using ApiObrasPrimas.DTOs;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace ApiObrasPrimas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObrasPrimasController : ControllerBase
    {
            [HttpGet]
            [Route("listarobras")]
            public IActionResult ListarObras()
            {
                var dao = new ObraDAO();
                var obras = dao.ListarObras();
                return Ok(obras);
            }

            [HttpGet]
            [Route("listarcarros")]
            public IActionResult ListarCarros()
            {
                var dao = new ObraDAO();
                var carros = dao.ListarCarros();
                return Ok(carros);
            }

            [HttpGet]
            [Route("listarquadros")]
            public IActionResult ListarQuadros()
            {
                var dao = new ObraDAO();
                var quadros = dao.ListarQuadros();
                return Ok(quadros);
            }

            [HttpPost]
            [Route("criarobra")]
            public IActionResult CriarObra([FromBody] ObraDTO obra)
            {
                var dao = new ObraDAO();
                dao.CriarObra(obra);
                return Ok();
            }

            [Route("removerobra")]
            [HttpDelete]
            public IActionResult RemoverObra(int id)
            {
                var dao = new ObraDAO();
                dao.RemoverObra(id);
                return Ok();
            }

            [HttpPut]
            [Route("alterarobra")]
            public IActionResult AlterarObra([FromBody] ObraDTO obra)
            {
                var dao = new ObraDAO();
                dao.AlterarObra(obra);
                return Ok();
            }
        }
    }
