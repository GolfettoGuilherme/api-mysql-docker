using System;
using Estudo_Api_Com_Banco.Models;
using Estudo_Api_Com_Banco.Service;
using Microsoft.AspNetCore.Mvc;

namespace Estudo_Api_Com_Banco.Controllers
{
    [ApiController]
    [Route("Aluno")]
    public class AlunoController : ControllerBase
    {
        public AlunoController()
        {
        }


        [HttpGet]
        [Route("")]
        public IActionResult List()
        {
            var conexao = new MySqlService();

            var alunos = conexao.List();

            return Ok(alunos);
        }

        [HttpPost]
        [Route("")]
        public IActionResult Add(Aluno aluno)
        {
            var conexao = new MySqlService();

            var result = conexao.Insert(aluno);

            return Ok(result);
        }

    }
}
