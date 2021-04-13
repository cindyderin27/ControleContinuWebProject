using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiApplication.Models;

namespace WebApiApplication.Controllers
{
    public class ProprietaireController : ApiController
    {
        ProprieteEntities db = new ProprieteEntities();

        [HttpGet]
        public IHttpActionResult GetListProprietaire(int index = 0, int taille = 10)
        {
            try
            {
                db.Configuration.ProxyCreationEnabled = false;
                var proprietaire= db.Proprietaire.Include(nameof(Proprietaire)).OrderByDescending(x => x.Bien).                  
                    Skip(index * taille).Take(taille).ToList();
                return Ok();

            }
          

            catch (Exception ex)

            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet]

        public IHttpActionResult GetProprietaire(int id)
        {
            try
            {
                var proprietaire = db.Proprietaire.Find(id);

                return Ok(proprietaire);

            }
            catch (DbUpdateException ex)
            {
                var exception = ex.InnerException?.InnerException as SqlException;
                return BadRequest(exception?.Message);

            }

            catch (Exception ex)

            {
                return BadRequest(ex.Message);
            }


        }

    }
}
