using System.Collections.Generic;

namespace DesignPatterns.FlyWeight
{
    public class TartarugaFlyWeight
    {
        private Dictionary<string, Tartaruga> dicTartaruga = new Dictionary<string, Tartaruga>();
        
        public Tartaruga GetTartaruga(string cor)
        {
            Tartaruga tartaruga = null;

            if (dicTartaruga.ContainsKey(cor))
            {
                tartaruga = dicTartaruga[cor];
            }
            else
            {
                switch (cor)
                {
                    case "Amarela":
                        tartaruga = new TartarugaAmarela();
                        break;
                    case "Azul":
                        tartaruga = new TartarugaAzul();
                        break;
                    case "Vermelha":
                        tartaruga = new TartarugaVermelha();
                        break;
                }

                dicTartaruga.Add(cor,tartaruga);
            }

            return tartaruga;
        }
    }
}
