using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Controller
{
    public class BebidaController : IBaseController<Bebida>
    {
        private readonly BebidaRepository _bebidaRepository;

        public BebidaController(BebidaRepository bebidaRepository)
        {
            _bebidaRepository = bebidaRepository;
        }
        // public BebidaController(BebidaRepository bebidaRepository)
        // {
        //     _bebidaRepository = bebidaRepository;
        // }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Bebida Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Bebida> GetAll()
        {
            return _bebidaRepository.GetAll();
        }

        public Bebida Post(Bebida entity)
        {
            _bebidaRepository.Create(entity);
            return entity;
        }

        public Bebida Update(int id, Bebida entity)
        {
            throw new NotImplementedException();
        }

        public void EncherGarrafaRetornavel(Bebida bebida)
        {
            _bebidaRepository.EncherGarrafaRetornavel(bebida);
        }
    }
}