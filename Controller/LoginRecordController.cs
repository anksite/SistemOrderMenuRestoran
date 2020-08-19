using SistemOrderMenuRestoran.Model.Context;
using SistemOrderMenuRestoran.Model.Entity;
using SistemOrderMenuRestoran.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemOrderMenuRestoran.Controller
{
    class LoginRecordController {
        LoginRecordRepository repo;
        public int Create(string id) {
            int result = 0;
          
            using (DbContext context = new DbContext()) {
                repo = new LoginRecordRepository(context);
                result = repo.Create(id);
            }
            return result;
        }

        public List<LoginRecord> RealAll() {
            using (DbContext context = new DbContext()) {
                repo = new LoginRecordRepository(context);
                return repo.RealAll();
            }
        }
    }
}
