
namespace SalarioDeFuncionarios2
{
    class Dados
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Dados(int id, string nome, double salario)
        {
            ID = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double aumento)
        {
            Salario += (aumento / 100) * Salario;
        }

        public override string ToString()
        {
            return "Updated list of employees: " + ID + ", " + Nome + ", " + Salario;
        }
    }
}
