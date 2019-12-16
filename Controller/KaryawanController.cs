using SistemOrderMenuRestoran.Model.Context;
using SistemOrderMenuRestoran.Model.Entity;
using SistemOrderMenuRestoran.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemOrderMenuRestoran.Controller
{
    class KaryawanController {
        KaryawanRepository repo;
        public string ReadLogin(string id, string pass){
            string role;
            using (DbContext context = new DbContext()){
                repo = new KaryawanRepository(context);
                role = repo.ReadLogin(id, pass);
            }
            return role;
        }
    }
}
