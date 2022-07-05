
namespace SalarioDeFuncionarios
{
    class Dados
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto - Imposto + SalarioBruto * porcentagem / 100;
        }

        public override string ToString()
        {
            return Nome + ", R$ " + SalarioBruto;
        }
    }
}
