using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;

#region
//Funcionario pedro = new Funcionario("123456789", 2000);
//pedro.Nome = "Pedro malazartes";


//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor("987654321");
//roberta.Nome = "Roberta Silva";

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonficacao);
//Console.WriteLine("Total de Funcionarios: " + Funcionario.TotalDeFuncionarios);

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine("Novo salário do Pedro: " + pedro.Salario);

//Console.WriteLine("Novo salário da Roberta: " + roberta.Salario);
#endregion

//CalcularBonificacao();


void CalcularBonificacao()
{
    usarSistema();
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("123456");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("987456");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("74581");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("852963");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(ulisses);

    Console.WriteLine("Total de Bonificação = "+ gerenciador.TotalDeBonificacao);

    //Funcionario pedro = new Funcionario("123456",852);
}

void usarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("9999999999");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Login = "Ingrid";
    ingrid.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("888888888888");
    ursula.Nome = "Ursula Silva";
    ursula.Login = "Ursula";
    ursula.Senha = "123";

    sistema.Logar(ingrid, "Ingrid", "123");
    sistema.Logar(ursula, "Ursua", "123");

    ParceiroComercial caio = new ParceiroComercial();
    caio.Login = "Caio";
    caio.Senha = "123";

    sistema.Logar(ursula, "Caio", "123");

}

usarSistema();




