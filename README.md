# REGISTAR AUTOMOBILA
Ova WinForms aplikacija izrađena je u sklopu testiranja za radno mjesto .NET developer-a u poduzeću INPRO d.o.o.
Više informacija dostupno je na Wiki stranici ovog repozitorija (https://github.com/mihstjepa/RegistarAutomobila/wiki/Opis-aplikacije).

## Kako isprobati aplikaciju na vašem računalu?
1. Preuzmite sve datoteke repozitorija
2. Napravite import baze podataka (MS SQL Server Management Studio) na localhostu pomoću već exportirane baze podataka. Datoteka za import nalazi na putanji "RegistarAutomobila\DatabaseExport\RegistarAutomobila.bacpac". Kratak video tutorial (trajanje 2:01 min) koji objašnjava kako importati .bacpac datoteku na vlastitu bazu podataka - https://www.youtube.com/watch?v=wNwjT6XJj2o
3. Otvorite datoteku "ReegistarAutomobila.sln"
4. Pritisnite tipku F5

## KORISNIČKI ZAHTJEVI (zadano od strane poduzeća)

Bitno je kod ovog zadatka držati se nekih pravila, jer te stvari se koriste kod nas pa je dobro da se na njih koncentriraš:

* Baza podataka neka bude Microsoft SQL (imaš za skinuti besplatnu Express verziju od Microsofta. Pazi da si instaliraš i SQL Management Studio za upravljanje bazom podataka te direktno pisanje SQL upita.
* .NET okruženje jezik može biti C# ili VB (Visual Studio pretpostavljam da imaš instaliran od prije kao IDE alat)
* Za komunikaciju s bazom možeš koristiti Entity Framework koji si rekao da imaš predznanje.
* Ostale alate koji će ti olakšat ili poboljšat aplikaciju možeš naravno koristiti po želji.

Aplikacija koju ćeš napraviti je Registar automobila. Aplikacija će ti se sastojati od dvije glavne cjeline. Jedna će ti biti za unos određenog modela, dok druga će ti biti za inicijalni unos marke automobila. Znači kod cjeline za unos marke automobila ćeš unijeti, ažurirati i brisati ove podatke:

* Naziv marke (npr. Volkswagen, Mercedes, Alfa Romeo,…)
* Država (iz koje države je proizvođač automobila)

Druga cjelina je za unos specifičnog modela određene marke. Ona će imati ove podatke:

* Marka (Odabir Marke automobila iz padajućeg izbornika. Za one sve koje smo unijeli u onoj prijašnjoj formi)
* Model automobila (naziv modela npr. Passat, Giulia)
* Godina proizvodnje
* Snaga motora (u KW)
* Cijena (u kunama)

Ta druga forma je i glavna forma i bitnija. Također svaki unos se isto može unositi, editirati i brisati. Dobro bi bilo i napraviti neko polje za pretraživanje automobila, npr. Po nazivu marke, modelu, ….. Eto ti si sad razmisli malo, kako će izgledati aplikacija, npr. da li će forma za unos biti zasebno ili u glavnoj formi gdje se i listaju podaci, onda kako će izgledati baza podataka za nju. Dizajn i ostale stvari su na tebi. Bitno je da aplikacija radi, te naravno da nema exceptiona i da bude OOP, što će ti sam Entity Framework puno pomoći kod toga, jer on drugačije nit ne funkcionira. Ukoliko ćeš imati kakva pitanja i nejasnoće slobodno me kontaktiraš.



## PROŠIRENJE KORISNIČKIH ZAHTJEVA
Iako u testnom zadatku nije bilo zadano, aplikacija ima dodatnu funkcionalnost autentikacije korisnika (Login) koji ovisno o dodjeljenim ulogama (npr. Admin, Običan korisnik, Moderator...) imaju restrikcije nad korištenjem pune funkcionalnosti aplikacije. Korisnik se može prijaviti u sustav tek kada mu Administrator kreira korisnički račun. Također, implementirana je validacija unosa podataka nad svim formama.

### PRAVA ULOGA:
Za sada je jedina implementirana restrikcija ovisno o ulozi (pravima) korisnika ta da korisnik koji je "Administrator" može vršiti CRUD nad Markama automobila, Modelima automobila, Korisnicima i Ulogama.

Sve ostale uloge mogu vršiti CRUD samo nad Markama automobila i Modelima automobila.

## BAZA PODATAKA
Baza podataka napravljena je u alatu Microsoft SQL Server Management Studio na localhost-u. Sastoji se od četiri tablice i nad svima je u aplikaciji implementirana CRUD funkcionalnost putem korisničkog sučelja.
### ERA model
![](https://github.com/mihstjepa/RegistarAutomobila/blob/master/ERAmodel(v1.0).png)



## KORIŠTENE TEHNOLOGIJE, ALATI I PRISTUPI

* C# (Visual Studio 2017)
* Windows Forms
* Database-First pristup (Entity Framework)
* LINQ
* OOP
* Microsoft SQL Server Management Studio
