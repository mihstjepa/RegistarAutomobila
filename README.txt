Ova aplikacija napravljena je kao testni zadatak za radno mjesto .NET developer
u poduzecu INPRO d.o.o.

TEKST ZADATKA ZADAN OD STRANE PODUZECA
---------------------------------------------------
Bitno je kod ovog zadatka držati se nekih pravila, jer te stvari se koriste kod nas pa je dobro da se na njih koncentriraš: 
•	Baza podataka neka bude Microsoft SQL (imaš za skinuti besplatnu Express verziju od Microsofta. Pazi da si instaliraš i SQL Management Studio za upravljanje bazom podataka te direktno pisanje SQL upita. 
•	.NET okruženje jezik može biti C# ili VB (Visual Studio pretpostavljam da imaš instaliran  od prije kao IDE alat)
•	za komunikaciju s bazom možeš koristiti Entity Framework koji si rekao da imaš predznanje. 
•	Ostale alate koji ce ti olakšat ili poboljšat aplikaciju možeš naravno koristiti po želji. 
Aplikacija koju ceš napraviti je Registar automobila. Aplikacija ce ti se sastojati od dvije glavne cjeline. Jedna ce ti biti za unos odredenog modela, dok druga ce ti biti za inicijalni unos marke automobila. Znaci kod cjeline za unos marke automobila ceš unijeti, ažurirati i brisati ove podatke: 
•	Naziv marke (npr. Volkswagen, Mercedes, Alfa Romeo,…)
•	Država (iz koje države je proizvodac automobila)
Druga cjelina  je za unos specificnog modela odredene marke. Ona ce imati ove podatke:
•	Marka (Odabir Marke automobila iz padajuceg izbornika. Za one sve koje smo unijeli u onoj prijašnjoj formi)
•	Model automobila (naziv modela npr. Passat, Giulia)
•	Godina proizvodnje 
•	Snaga motora (u KW)
•	Cijena (u kunama)
Ta druga forma je i glavna forma i bitnija. Takoder svaki unos se isto može unositi, editirati i brisati. Dobro bi bilo i napraviti neko polje za pretraživanje automobila, npr. Po nazivu marke, modelu, …..
Eto ti si sad razmisli malo, kako ce izgledati aplikacija, npr. da li ce forma za unos biti zasebno ili u glavnoj formi gdje se i listaju podaci, onda kako ce izgledati baza podataka za nju. Dizajn i ostale stvari su na tebi. Bitno je da aplikacija radi, te naravno da nema exceptiona i da bude OOP, što ce ti sam Entity Framework puno pomoci kod toga, jer on drugacije nit ne funkcionira ?
Ukoliko ceš imati kakva pitanja i nejasnoce slobodno me kontaktiraš. 




UPDATE:
Funkcionalnost je proširena dodavanjem Login funkcionalnosti te autentikacije korisnika sa pripadnim ulogama.
Ovo originalno nije bio zahtjev poduzeca nego inicijativa autora.
