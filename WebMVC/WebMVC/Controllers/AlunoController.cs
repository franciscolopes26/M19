﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.Models;
using System.IO;
using MySql.Data.MySqlClient;

namespace WebMVC.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        public ActionResult CriaAluno()
        {
            return View();
        }
        [HttpPost]

        public ActionResult CriaAluno(aluno aluno)
        {
            if (ModelState.IsValid)
            {
                string ImagemNome = Path.GetFileNameWithoutExtension(aluno.imagem.FileName);
                string ImagemExt = Path.GetExtension(aluno.imagem.FileName);
                ImagemNome = DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + ImagemNome.Trim() + ImagemExt;
                aluno.ImgPath = @"\Content\Imagens\" + ImagemNome;
                aluno.imagem.SaveAs(ControllerContext.HttpContext.Server.MapPath(aluno.ImgPath));

                ConexaoBD conn = new ConexaoBD("localhost", 3307, "root", "root", "formacao");

                using (MySqlConnection conexao = conn.ObterConexao())
                {
                    if (conexao != null)
                    {
                        string stm = "insert into alunos values(0,@primeiroNome, @ultimoNome,@morada, @genero, @dataNasc, @ano, @foto)";
                        
                        using (MySqlCommand cmd = new MySqlCommand(stm, conexao))
                        {
                            cmd.Parameters.AddWithValue("@primeiroNome", aluno.PriNome);
                            cmd.Parameters.AddWithValue("@ultimoNome", aluno.UltNome);
                            cmd.Parameters.AddWithValue("@morada", aluno.Morada);
                            cmd.Parameters.AddWithValue("@genero", aluno.Genero);
                            cmd.Parameters.AddWithValue("@dataNasc", aluno.DataNasc);
                            cmd.Parameters.AddWithValue("@ano", aluno.AnoEscolaridade);
                            cmd.Parameters.AddWithValue("@foto", aluno.ImgPath);

                            int nRgistos = cmd.ExecuteNonQuery();



                        }


                    }
                }
            }
            return RedirectToAction("CriaAluno");
        }

        public ActionResult ListarAluno()
        {
            ConexaoBD Conn = new ConexaoBD("localhost", 3307, "root", "root", "formacao");
            List<aluno> lista = new List<aluno>();
            using(MySqlConnection conexao= Conn.ObterConexao())
            {
                if (conexao != null)
                    using (MySqlCommand cmd = new MySqlCommand("select * from alunos", conexao))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new aluno()
                                {
                                Naluno = reader.GetInt32("idAlunos"),
                                PriNome = reader.GetString("nome"),
                                UltNome = reader.GetString("ultimo_nome"),
                                Morada = reader.GetString("morada"),
                                Genero = reader.GetString("genero") == "Masculino" ? Genero.Masculino : Genero.Feminino,
                                DataNasc = reader.GetDateTime("datanasc"),
                                AnoEscolaridade = reader.GetInt16("ano_escolaridade"),

                                });
                            }

                        }
                              
                           
                     
                    }
            }

            return View(lista);



            
        }

        public ActionResult DetalheAluno(int id)
        {
            ConexaoBD Conn = new ConexaoBD("localhost", 3307, "root", "root", "formacao");
            aluno Aluno = null;
            using (MySqlConnection conexao = Conn.ObterConexao())
            {
                if(conexao!=null)
                {
                    using (MySqlCommand cmd = new MySqlCommand("select*from alunos where idalunos=@idalunos", conexao))
                    {
                        cmd.Parameters.AddWithValue("@idalunos", id);
                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Aluno = new aluno()
                                {
                                    Naluno = reader.GetInt32("idAlunos"),
                                    PriNome = reader.GetString("nome"),
                                    UltNome = reader.GetString("ultimo_nome"),
                                    Morada = reader.GetString("morada"),
                                    Genero = reader.GetString("genero") == "Masculino" ? Genero.Masculino : Genero.Feminino,
                                    DataNasc = reader.GetDateTime("datanasc"),
                                    AnoEscolaridade = reader.GetInt16("ano_escolaridade"),
                                    ImgPath = reader.GetString("foto")
                                };
                                return View(Aluno);

                            }
                        }

                    }




                }




            }
            return RedirectToAction("ListarAluno");

        }



    }
    
}
