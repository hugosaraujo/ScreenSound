using ScreenSound.Modelos;

Album okComputer = new Album();
okComputer.Nome = "Ok Computer";


Musica karmaPolice = new Musica();
karmaPolice.Faixa = "Karma Police";
karmaPolice.DuracaoEmSegundos = 261;

Musica paranoidAndroid = new Musica();
paranoidAndroid.Faixa = "Paranoid Android";
paranoidAndroid.DuracaoEmSegundos = 383;

Musica airbag = new Musica()
{
    Faixa = "Airbag",
    DuracaoEmSegundos = 264
};


okComputer.AdcionarFaixa(karmaPolice);
okComputer.AdcionarFaixa(airbag);
okComputer.AdcionarFaixa(paranoidAndroid);

okComputer.ExibirFichaTecnica();
