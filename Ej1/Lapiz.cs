using Newtonsoft.Json;

namespace Ej1
{
    public class Lapiz
    {
        #region Atributos
        [JsonProperty("longitudPunta")]
        public double LongitudPunta { get; set; }

        [JsonProperty("longitudCuerpo")]
        public double LongitudCuerpo { get; set; }
        #endregion Atributos

        #region Métodos
        public void SacarPunta(int vueltas)        
        {
            for (int i = 0; i < vueltas; i++)
            {
                AumentarPunta();
                DisminuirCuerpo();
            }
        }
        #endregion Métodos

        #region Comportamientos
        private void AumentarPunta()
        {
            LongitudPunta += 0.5;
        }

        private void DisminuirCuerpo()
        {
            LongitudCuerpo -= 0.5;
        }
        #endregion Comportamientos
    }
}