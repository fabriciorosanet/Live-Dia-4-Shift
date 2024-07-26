/*
 * Nosso switch monitora a variavel "codigo" e exibe
 * diferentes mensagens caso o valor dessa variavel seja 1,2 ou 3. 
 * Caso tenha qualquer outro valor, será exibida a mensagem do bloco DEFAULT
 


int codigo;
string mensagem;
Console.Write("Digite o código: ");
codigo = Convert.ToInt32(Console.ReadLine());

switch (codigo) 
{
    case 1:
        mensagem = "Você escolheu a opção ELOGIO PROFISSIONAL";
        break;
    case 2:
        mensagem = "Você escolheu a opção ELOGIO FÍSICO";
        break;
    case 3:
        mensagem = "Você escolheu a opção ELOGIO PESSOAL";
        break;
    default:
        mensagem = "Opção Inválida";
        break;
}

Console.WriteLine(mensagem);

*/



