/*
Escreva um algoritmo para calcular e exibir o número de lâmpadas necessárias para iluminar determinado cômodo de uma residência.
Entrada de dados: a potência da lâmpada utilizada (em watts) e as dimensões (largura e comprimento, em metros) do cômodo.

Considere que a potência necessária é de 18 watts por metro quadrado.

Processamento: após o algoritmo obter os dados de entrada, ele segue a seguinte sequência:

Calcula quantos metros quadrados possui o cômodo multiplicando width por length.
Calcula o quociente X dividindo a potência da lâmpada que será utilizada por 18, quantidade necessária para iluminar 1 metro quadrado.
Calcula a quantidade de lâmpadas necessárias dividindo o total de metros quadrados do cômodo pelo quociente X.
Saída de Dados: Uma mensagem coerente e bem formatada deve ser exibida na tela do Console para a pessoa que utiliza o programa e forneceu os dados de entrada.
*/


Console.WriteLine("Boas vindas ao programa 'Calcula Lâmpada'!");

Console.WriteLine("Informe o nome do cômodo: ");
string? convenient = Console.ReadLine();

Console.WriteLine("Informe em metros a largura deste cômodo: ");
string? readWith = Console.ReadLine();
decimal.TryParse(readWith, out decimal width);

Console.WriteLine("Informe em metros o comprimento deste cômodo: ");
string? readLength = Console.ReadLine();
decimal.TryParse(readLength, out decimal length);

Console.WriteLine("Informe a potência em watts da lâmpada que será utilizada: ");
string? readpower = Console.ReadLine();
int.TryParse(readpower, out int power);

decimal squareMeter = width * length;
decimal quotientX = power / 18M;
decimal totalLightBulbs = squareMeter / quotientX;

Console.WriteLine("Para iluminar o cômodo: " + convenient + " com " + squareMeter.ToString("N2") + " metros quadrados " + "será necessário a instalação de " + totalLightBulbs.ToString("N2") + " lâmpada(s)");
