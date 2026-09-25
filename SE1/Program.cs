using System;
namespace SE1

{
	class Program
	{
		static void Main(string[]args)
		{
			// Sesión 9: Examen
			// Sesión 10: Soluciónn de examen			
			//1.Proyecto en C#
			// 2. Sintaxis
			// Tipo_de_dato identificador_variable;
			bool a;
			int numero;
			// 3.Interpolación
			// Combinación de datos dentro de una cadena
			a = true;
			numero = 10;
			Console.WriteLine($"Booleano: {a}");
			Console.WriteLine($"Número: {numero}");
			// 4. Incrementos y decrementos
			int m = 0;
			int n = -1;
			m += 1;
			n-= 3;
			m -= 5;
			n += 9;
			// 5. Operador resto (módulo)
			int residuo = 40 % 16;
			Console.WriteLine($"Residuo: {residuo}");
			// 6. Operadores aritméticos
			double operación = 0;
			operación = ((30 + 8 - 2) / 2) * -1;
			Console.WriteLine($"Operación: {operación}");
			// 7.Interruptores
			bool interruptor_1 = false;
			bool interruptor_2 = true;
            bool bombilla;
			if (interruptor_1 && interruptor_2)
			{
		         bombilla = true;
			}
			else
			{
			     bombilla = false;
			}
			Console.WriteLine($"Bombilla: {bombilla}");
			// 8. Asueto
			int dia = 16;
			string mes = "Septiembre";
			if ( dia == 16 && mes == "Septiembre")
			  {
			  Console.WriteLine($"Hay asueto.");
			  }
			else  
			{
			Console.WriteLine($"Sin definir");
			}
			// 9. Expresión
			bool resultado = 7<11 && 9 != 0;
			Console.WriteLine($"Expresión: {resultado}");
		}
	}
}