using Data.Repositories;
using Data.Persistence;
using System.Data.Entity.Infrastructure;
using System;
using Data;
using Data.Persistance;

namespace Data
{
    /**
     *  Patron Singleton para acceso a una unico contexto de base de datos
     * 
     **/
    public class ContextUnit
    {
        private static ContextUnit _unit;
        public static ContextUnit Unit {
            get
            {
                if (_unit == null)
                {
                    _unit = new ContextUnit();
                }
                return _unit;
            }
            set => _unit = value;
        }
        private readonly AcademiaContext _context;
        private bool _disposed = false;

        public IComisionRepository ComisionRepository { get; private set; }
        public ICursoRepository CursoRepository { get; private set; }
        public IDocenteCursoRepository DocenteCursoRepository { get; private set; }
        public IEspecialidadRepository EspecialidadRepository { get; private set; }
        public IInscripcionRepository InscripcionRepository { get; private set; }
        public IMateriaRepository MateriaRepository { get; private set; }
        public IModuloRepository ModuloRepository { get; private set; }
        public IModuloUsuarioRepository ModuloUsuarioRepository { get; private set; }
        public IPersonaRepository PersonaRepository { get; private set; }
        public IPlanRepository PlanRepository { get; private set; }
        public IUsuarioRepository UsuarioRepository { get; private set; }
        

        public ContextUnit()
        {
            _context = new AcademiaContext ();
            ComisionRepository = new ComisionRepository(_context);
            CursoRepository = new CursoRepository(_context);
            DocenteCursoRepository = new DocenteCursoRepository(_context);
            EspecialidadRepository = new EspecialidadRepository(_context);
            InscripcionRepository = new InscripcionRepository(_context);
            MateriaRepository = new MateriaRepository(_context);
            ModuloRepository = new ModuloRepository(_context);
            ModuloUsuarioRepository = new ModuloUsuarioRepository(_context);
            PersonaRepository = new PersonaRepository(_context);
            PlanRepository = new PlanRepository(_context);
            UsuarioRepository = new UsuarioRepository(_context);
        }

        public int Complete()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}