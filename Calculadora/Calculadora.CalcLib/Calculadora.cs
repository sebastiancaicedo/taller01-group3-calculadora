using System.Threading.Tasks;

namespace Calculadora.CalcLib
{
    public class Calculadora
    {
        public Task<int> Suma(int a, int b)
        {
            return Task.FromResult(a + b);
        }

        public Task<long> Suma(long a, long b)
        {
            return Task.FromResult(a + b);
        }
        
        public Task<float> Suma(float a, float b)
        {
            return Task.FromResult(a + b);
        }

        public Task<double> Suma(double a, double b)
        {
            return Task.FromResult(a + b);
        }

        public Task<decimal> Suma(decimal a, decimal b)
        {
            return Task.FromResult(a + b);
        }

    }
}