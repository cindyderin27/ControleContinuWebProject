using System;
using System.Collections.Generic;
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

    }
}
