using CodigoComun.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoComun.Repository
{
    public class DepositoRepository
    {
        private StockAppContext db = new StockAppContext();

        public List<Deposito> GetTodosLosDepositos()
        {
            List<Deposito> depositoADevolver = new List<Deposito>();
            depositoADevolver = db.Depositos.ToList();

            return depositoADevolver;
        }

        public Deposito GetDepositoPorId(int idDeposito)
        {
            Deposito depositoADevolver = db.Depositos.Where(p => p.Id == idDeposito).FirstOrDefault();

            return depositoADevolver;
        }

        public int EliminarDeposito(int idDepositoAEliminar)
        {
            Deposito depositoAEliminar = GetDepositoPorId(idDepositoAEliminar);
            db.Depositos.Remove(depositoAEliminar);

            int r = db.SaveChanges();
            return r;
        }


        public int AddDeposito(Deposito depositoAAgregar)
        {
            db.Depositos.Add(depositoAAgregar);

            int r = db.SaveChanges();
            return r;
        }

        public int UpdateDeposito(Deposito depositoAModificar)
        {
            db.Entry(depositoAModificar).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return db.SaveChanges();
        }


    }
}
