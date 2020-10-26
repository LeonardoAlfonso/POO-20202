using System;
using System.Collections.Generic;

namespace Patrones.Observer
{
    public class GestorAlarmas
    {
        #region Properties
        private List<IObserverAlarma> suscribers;
        public List<IObserverAlarma> Suscribers
        {
            get { return suscribers; }
            set { suscribers = value; }
        }
        #endregion Properties

        #region Initialize
        public GestorAlarmas()
        {
            Suscribers = new List<IObserverAlarma>();
        }
        #endregion Initialize


        #region Methods
        public void Suscribe(IObserverAlarma suscriber)
        {
            Suscribers.Add(suscriber);
        }
        public void Unsuscribe(IObserverAlarma suscriber)
        {
            Suscribers.Remove(suscriber);
        }
        public void Notify(string problemaSeguridad)
        {
            Suscribers.ForEach(s => {
                s.update(problemaSeguridad);
            });
        }
        #endregion Methods
    }
}