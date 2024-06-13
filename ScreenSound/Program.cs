using ScreenSound.Modelos;

Artista weezer = new("Weezer");

Album blue = new("Weezer(Blue Album)");

Album green = new("Weezer(Green Album)");

weezer.AdicionarAlbum(blue);
weezer.AdicionarAlbum(green);
weezer.ExibeFichaTecnica();

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

okComputer.ExibirFichaTecnica();
