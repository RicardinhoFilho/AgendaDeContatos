using Agenda_de_Contatos.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda_de_Contatos.Controllers
{
    public class PessoasController : Controller
    {
        private readonly Contexto _contexto;//Acesso ao banco de dados 
        private readonly IWebHostEnvironment _webHostEnvironment; //Para termos acesso ao repositório e manipularmos imagens

        public PessoasController(Contexto contexto, IWebHostEnvironment webHostEnvironment)//Injeção de dependências
        {
            _contexto = contexto;
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _contexto.Pessoas.ToListAsync());
        }

        [HttpGet]
        public IActionResult CriarPessoa()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> CriarPessoa(Pessoa pessoa, IFormFile foto)
        {
            if (ModelState.IsValid)
            {
                if (foto != null)
                {
                    string diretorio = Path.Combine(_webHostEnvironment.WebRootPath, "img");
                    string nomeFoto = Guid.NewGuid().ToString() + foto.FileName;

                    using (FileStream fileStream = new FileStream(Path.Combine(diretorio, nomeFoto), FileMode.CreateNew))
                    {
                        await foto.CopyToAsync(fileStream);
                        pessoa.Foto = "~/img/" + nomeFoto;
                    }
                }
                else
                {
                    pessoa.Foto = "~/img/ImagemPadrao.png";
                }

                _contexto.Add(pessoa);
                await _contexto.SaveChangesAsync();
                TempData["ContatoNovo"] = $"Contato com nome {pessoa.Nome} {pessoa.Sobrenome} incluído com sucesso";
                return RedirectToAction(nameof(Index));
            }

            return View(pessoa);
        }

        [HttpGet]
        public async Task<IActionResult> AtualizarPessoa(int pessoaId)
        {
            Pessoa pessoa = await _contexto.Pessoas.FindAsync(pessoaId);//Pegando a pessoa já existente pelo id

            if (pessoa == null)
            {
                return NotFound();//Erro 404
            }

            TempData["Foto"] = pessoa.Foto;
            return View(pessoa);
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarPessoa(Pessoa pessoa, IFormFile foto)
        {
            if (ModelState.IsValid)
            {
                if (foto != null)
                {
                    string diretorio = Path.Combine(_webHostEnvironment.WebRootPath, "img");

                    string nomeFoto = Guid.NewGuid().ToString() + foto.FileName;

                    using (FileStream fileStream = new FileStream(Path.Combine(diretorio, nomeFoto), FileMode.Create))
                    {
                        await foto.CopyToAsync(fileStream);
                        pessoa.Foto = "~/img/" + nomeFoto;
                        TempData["Foto"] = null;
                    }
                }
                else
                {
                    pessoa.Foto = TempData["Foto"].ToString();
                }
                _contexto.Update(pessoa);
                await _contexto.SaveChangesAsync();
                TempData["Contato Atualizado"] = $"Contato {pessoa.Nome} {pessoa.Sobrenome} atualizado com sucesso!";

                return RedirectToAction(nameof(Index));
            }

            return View(pessoa);

        }

        
        [HttpPost]
        public async Task<JsonResult> ExcluirPessoa(int pessoaId)
        {
            Pessoa pessoa = await _contexto.Pessoas.FindAsync(pessoaId);
            _contexto.Pessoas.Remove(pessoa);
            await _contexto.SaveChangesAsync();
            TempData["ContatoExcluido"] = $"Contato com nome {pessoa.Nome} {pessoa.Sobrenome} excluído com sucesso";
            return Json(true);
        }
    }
}
