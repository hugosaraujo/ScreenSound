using ScreenSound.Modelos;
using ScreenSound.Modelos.Podcast;

Artista radiohead = new("Radiohead");

Album okComputer = new Album("Ok Computer");

Musica karmaPolice = new Musica("Karma Police", radiohead);
karmaPolice.DuracaoEmSegundos = 261;

Musica paranoidAndroid = new Musica("Paranoid Android", radiohead);
paranoidAndroid.DuracaoEmSegundos = 383;

Musica airbag = new Musica("Airbag", radiohead)
{
    DuracaoEmSegundos = 264
};

okComputer.AdcionarFaixa(karmaPolice);
okComputer.AdcionarFaixa(airbag);
okComputer.AdcionarFaixa(paranoidAndroid);

Artista chiclete = new Artista("Chiclete com Banana");
Musica selvaBranca = new Musica("Selva Branca", chiclete);
Musica digaQueValeu = new Musica("Diga que valeu", chiclete);

//Playlist playlist = new("Chiclete com Banana as mais alegres, Radiohead as mais tristes");
//playlist.AdicionarMusica(digaQueValeu);
//playlist.AdicionarMusica(airbag);
//playlist.AdicionarMusica(paranoidAndroid);
//playlist.AdicionarMusica(digaQueValeu);
//playlist.AdicionarMusica(karmaPolice);

//playlist.ExibirMusicas();

Episodio episodio = new Episodio(1, "Dia dos Namorados", 15);

Podcast pod1 = new Podcast("Mano Brown", "Mano a Mano");

episodio.AdicionarConvidado("Douglas Silva");
episodio.AdicionarConvidado("Darlan Cunha");

Console.WriteLine(episodio.Resumo);
