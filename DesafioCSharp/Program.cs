namespace DesafioCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int mainProgram = 1;

            while (mainProgram == 1)
            {
                double mediaFinal = 0.0;
                string resultado;

                Console.WriteLine("Digite a quantidade de notas a ser calculada:");
                int quantidadeAtividades = Convert.ToInt32(Console.ReadLine());

                for (int atividade = 1; atividade <= quantidadeAtividades; atividade++)
                {
                    Console.WriteLine($"Digite a {atividade}° nota:");
                    int valorNota = Convert.ToInt32(Console.ReadLine());
                    mediaFinal += valorNota;
                }

                mediaFinal /= quantidadeAtividades;

                if (mediaFinal >= 6) resultado = "Aluno aprovado!";
                else resultado = "Aluno de recuperação!";

                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine($"A media do aluno foi de : {mediaFinal.ToString("F2")}");
                Console.WriteLine(resultado);
                Console.WriteLine("Deseja calcular outra media?");
                Console.WriteLine("1.Sim     2. Nao");
                mainProgram = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------------------------------------------");

            }


        }
    }
}