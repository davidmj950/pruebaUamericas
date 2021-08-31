using System;

namespace Prueba.UAM.Inscripciones.Data
{
    public class DaoBase : IDisposable
    {
        public PRUEBA_UAMEntities Context;

        public void SetUpContext(bool enableLazyLoading = false, bool enableProxyCreation = false)
        {
            Context = new PRUEBA_UAMEntities();
            Context.Configuration.LazyLoadingEnabled = enableLazyLoading;
            Context.Configuration.ProxyCreationEnabled = enableProxyCreation;
            //Context.Database.CommandTimeout = 60;
        }

        /// <summary>
        /// Libera los recursos de la clase.
        /// </summary>
        public void Dispose()
        {
            this.Context = null;
        }
    }
}
