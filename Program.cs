namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criação de um array vazio:
            int[] arrayVazio = new int[7]; //0-6            
            
            //atribuição de valores
            arrayVazio[0] = 12;            
            arrayVazio[1] = 14;            
            arrayVazio[2] = 23;            
            arrayVazio[3] = 28;           
            arrayVazio[4] = 34;            
            arrayVazio[5] = 45;            
            arrayVazio[6] = 56;            
            int[] numeros = { 1, 2354, 367, 4567, 53, 63 };   
            
            Console.WriteLine(arrayVazio[4]);         
            Console.WriteLine(numeros[4]);      
            
            string[] alunos = new string[4];         
            alunos[0] = "Igor";         
            alunos[1] = "Laura";      
            alunos[2] = "Jorge";      
            alunos[3] = "Marco";   
            
            //imprimir toda a lista
            for (int i = 0; i < 4; i++){
                Console.WriteLine(alunos[i]); 
                
            }

            foreach (string nome in alunos) {
                Console.WriteLine(nome); 
            }

        }
    }
}