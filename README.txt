Ova aplikacija napravljena je kao testni zadatak za radno mjesto .NET developer
u poduzecu INPRO d.o.o.

TEKST ZADATKA ZADAN OD STRANE PODUZECA
---------------------------------------------------
Bitno je kod ovog zadatka dr�ati se nekih pravila, jer te stvari se koriste kod nas pa je dobro da se na njih koncentrira�: 
�	Baza podataka neka bude Microsoft SQL (ima� za skinuti besplatnu Express verziju od Microsofta. Pazi da si instalira� i SQL Management Studio za upravljanje bazom podataka te direktno pisanje SQL upita. 
�	.NET okru�enje jezik mo�e biti C# ili VB (Visual Studio pretpostavljam da ima� instaliran  od prije kao IDE alat)
�	za komunikaciju s bazom mo�e� koristiti Entity Framework koji si rekao da ima� predznanje. 
�	Ostale alate koji ce ti olak�at ili pobolj�at aplikaciju mo�e� naravno koristiti po �elji. 
Aplikacija koju ce� napraviti je Registar automobila. Aplikacija ce ti se sastojati od dvije glavne cjeline. Jedna ce ti biti za unos odredenog modela, dok druga ce ti biti za inicijalni unos marke automobila. Znaci kod cjeline za unos marke automobila ce� unijeti, a�urirati i brisati ove podatke: 
�	Naziv marke (npr. Volkswagen, Mercedes, Alfa Romeo,�)
�	Dr�ava (iz koje dr�ave je proizvodac automobila)
Druga cjelina  je za unos specificnog modela odredene marke. Ona ce imati ove podatke:
�	Marka (Odabir Marke automobila iz padajuceg izbornika. Za one sve koje smo unijeli u onoj prija�njoj formi)
�	Model automobila (naziv modela npr. Passat, Giulia)
�	Godina proizvodnje 
�	Snaga motora (u KW)
�	Cijena (u kunama)
Ta druga forma je i glavna forma i bitnija. Takoder svaki unos se isto mo�e unositi, editirati i brisati. Dobro bi bilo i napraviti neko polje za pretra�ivanje automobila, npr. Po nazivu marke, modelu, �..
Eto ti si sad razmisli malo, kako ce izgledati aplikacija, npr. da li ce forma za unos biti zasebno ili u glavnoj formi gdje se i listaju podaci, onda kako ce izgledati baza podataka za nju. Dizajn i ostale stvari su na tebi. Bitno je da aplikacija radi, te naravno da nema exceptiona i da bude OOP, �to ce ti sam Entity Framework puno pomoci kod toga, jer on drugacije nit ne funkcionira ?
Ukoliko ce� imati kakva pitanja i nejasnoce slobodno me kontaktira�. 




UPDATE:
Funkcionalnost je pro�irena dodavanjem Login funkcionalnosti te autentikacije korisnika sa pripadnim ulogama.
Ovo originalno nije bio zahtjev poduzeca nego inicijativa autora.
