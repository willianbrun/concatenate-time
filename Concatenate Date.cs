using System;
					
public class Program
{
	public static void Main()
	{
		//TAMAMNHO DO ARRAY
		int TAM = 4;
		
		//Variáveis a serem usadas no programa
		var hours = 0;
		var minutes = 0;
		var seconds = 0;
		
		//Declaração de array de strings estático
		string[] horarios;
		horarios = new string[TAM];
		
		//Elementos do array estáticos
		horarios[0] = "00:45:15";
		horarios[1] = "23:19:05";
		horarios[2] = "00:15:55";		
		horarios[3] = "04:59:00";

		
		//Pra cada horario
		foreach (string horario in horarios)
		{
			//Separa as horas, dos minutos, dos segundos
			string[] hr = horario.Split(':');
			
			//Concatena cada um respectivo
			hours = hours + Int16.Parse(hr[0]);
			minutes = minutes + Int16.Parse(hr[1]);
			seconds = seconds + Int16.Parse(hr[2]);
		}
		//A cada 60 segundos, transforma em 1 minuto
		while (seconds >= 60)
		{
			minutes = minutes + 1;
			seconds = seconds - 60;
		}
		//A cada 60 minutos, transforma em 1 hora
		while (minutes >= 60)
		{
			hours = hours + 1;
			minutes = minutes - 60;
		}
		Console.WriteLine(hours + ":" + minutes + ":" + seconds);
	}
}