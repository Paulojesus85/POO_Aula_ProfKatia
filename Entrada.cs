namespace Aula2_RA6322501
{
    public class Entrada
    {
        private double valor;
        private int poltrona;
        private string data;
        private string hora;

        public double GetValor()
        {
            return this.valor;
        }
        public void SetValor(double valor)
        {
            this.valor = valor;
        }
        public int GetPoltrona()
        {
            return this.poltrona;
        }
        public void SetPoltrona(int poltrona)
        {
            this.poltrona = poltrona;
        }
        public string GetData()
        {
            return this.data;
        }
        public void SetData(string data)
        {
            this.data = data;
        }
        public string GetHora()
        {
            return this.hora;
        }
        public void SetHora(string hora)
        {
            this.hora = hora;
        }



        //public double Valor { get; set; }
        //public int Poltrona { get; set; }
        //public int Data { get; set; }
        //public int Hora { get; set; }

    }
}
