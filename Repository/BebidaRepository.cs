using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class BebidaRepository : IBebidaServices, IBaseRepository<Bebida>
    {
        private List<Bebida> _bebidaList;
        public BebidaRepository()
        {
            _bebidaList = new List<Bebida>();
        }
        public Bebida Create(Bebida entity)
        {
            _bebidaList.Add(entity);
            return entity;
        }

        public void Delete(int id)
        {
            var bebida = _bebidaList.FirstOrDefault(x => x.BebidaId == id) ??
                throw new NullReferenceException("Bebida não encontrada.");

            _bebidaList.Remove(bebida);
        }

        public void EncherGarrafaRetornavel(Bebida bebida)
        {
            Console.WriteLine($"{bebida.Nome} foi enchida.");
        }

        public Bebida Get(int id)
        {
            var bebida = _bebidaList.FirstOrDefault(x => x.BebidaId == id);

            return bebida;
        }

        public List<Bebida> GetAll()
        {
            return _bebidaList.ToList();
        }

        public Bebida Update(Bebida entity)
        {
            var bebida = _bebidaList.FirstOrDefault(x => x.BebidaId == entity.BebidaId) ??
                throw new NullReferenceException("Bebida não encontrada.");

            bebida.Nome = entity.Nome;
            bebida.Valor = entity.Valor;

            return bebida;
        }
    }
}