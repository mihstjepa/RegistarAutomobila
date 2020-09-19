func @_RegistarAutomobila.Forme.Dodavanje.FrmDodajKorisnika.btnNatrag_Click$object.System.EventArgs$(none, none) -> () loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :32 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :32 :37)
cbde.store %_sender, %0 : memref<none> loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :32 :37)
%1 = cbde.alloca none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :32 :52)
cbde.store %_e, %1 : memref<none> loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :32 :52)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :34 :12) // this (ThisExpression)
%3 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :34 :12) // this.Hide() (InvocationExpression)
%4 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :35 :44) // new FrmUpravljanjeKorisnika() (ObjectCreationExpression)
%6 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :36 :12) // Not a variable of known type: forma
%7 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :36 :12) // forma.ShowDialog() (InvocationExpression)
%8 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :37 :12) // this (ThisExpression)
%9 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :37 :12) // this.Close() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_RegistarAutomobila.Forme.Dodavanje.FrmDodajKorisnika.btnSpremi_Click$object.System.EventArgs$(none, none) -> () loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :45 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :45 :37)
cbde.store %_sender, %0 : memref<none> loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :45 :37)
%1 = cbde.alloca none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :45 :52)
cbde.store %_e, %1 : memref<none> loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :45 :52)
br ^0

^0: // BinaryBranchBlock
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: ProvjeraUnosa
%2 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :47 :28) // ProvjeraUnosa() (InvocationExpression)
%4 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :49 :16) // Not a variable of known type: poruka
%5 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :49 :26) // "" (StringLiteralExpression)
%6 = cbde.unknown : i1  loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :49 :16) // comparison of unknown type: poruka != ""
cond_br %6, ^1, ^2 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :49 :16)

^1: // SimpleBlock
// Entity from another assembly: MessageBox
%7 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :51 :32) // Not a variable of known type: poruka
%8 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :51 :16) // MessageBox.Show(poruka) (InvocationExpression)
br ^3

^2: // SimpleBlock
%9 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :55 :40) // new Korisnik()                  {                      Korime = txtBoxKorime.Text,                      Ime = txtBoxIme.Text,                      Prezime = txtBoxPrezime.Text,                      Lozinka = txtBoxLozinka.Text,                      UlogaId = DohvatiSifruUloge()                  } (ObjectCreationExpression)
%10 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :57 :29) // Not a variable of known type: txtBoxKorime
%11 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :57 :29) // txtBoxKorime.Text (SimpleMemberAccessExpression)
%12 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :58 :26) // Not a variable of known type: txtBoxIme
%13 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :58 :26) // txtBoxIme.Text (SimpleMemberAccessExpression)
%14 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :59 :30) // Not a variable of known type: txtBoxPrezime
%15 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :59 :30) // txtBoxPrezime.Text (SimpleMemberAccessExpression)
%16 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :60 :30) // Not a variable of known type: txtBoxLozinka
%17 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :60 :30) // txtBoxLozinka.Text (SimpleMemberAccessExpression)
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: DohvatiSifruUloge
%18 = cbde.unknown : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :61 :30) // DohvatiSifruUloge() (InvocationExpression)
%20 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :64 :16) // Not a variable of known type: db
%21 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :64 :16) // db.Korisnik (SimpleMemberAccessExpression)
%22 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :64 :32) // Not a variable of known type: noviKorisnik
%23 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :64 :16) // db.Korisnik.Add(noviKorisnik) (InvocationExpression)
%24 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :65 :16) // Not a variable of known type: db
%25 = cbde.unknown : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :65 :16) // db.SaveChanges() (InvocationExpression)
// Entity from another assembly: MessageBox
%26 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :66 :32) // "Uspješan unos!" (StringLiteralExpression)
%27 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :66 :16) // MessageBox.Show("Uspješan unos!") (InvocationExpression)
%28 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :68 :16) // this (ThisExpression)
%29 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :68 :16) // this.Hide() (InvocationExpression)
%30 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :69 :48) // new FrmUpravljanjeKorisnika() (ObjectCreationExpression)
%32 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :70 :16) // Not a variable of known type: forma
%33 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :70 :16) // forma.ShowDialog() (InvocationExpression)
%34 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :71 :16) // this (ThisExpression)
%35 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :71 :16) // this.Close() (InvocationExpression)
br ^3

^3: // ExitBlock
return

}
func @_RegistarAutomobila.Forme.Dodavanje.FrmDodajKorisnika.OsvjeziPrikaz$$() -> () loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :79 :8) {
^entry :
br ^0

^0: // SimpleBlock
%0 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :81 :12) // Not a variable of known type: txtBoxKorime
%1 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :81 :12) // txtBoxKorime.Text (SimpleMemberAccessExpression)
%2 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :81 :32) // "" (StringLiteralExpression)
%3 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :82 :12) // Not a variable of known type: txtBoxIme
%4 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :82 :12) // txtBoxIme.Text (SimpleMemberAccessExpression)
%5 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :82 :29) // "" (StringLiteralExpression)
%6 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :83 :12) // Not a variable of known type: txtBoxPrezime
%7 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :83 :12) // txtBoxPrezime.Text (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :83 :33) // "" (StringLiteralExpression)
%9 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :84 :12) // Not a variable of known type: txtBoxLozinka
%10 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :84 :12) // txtBoxLozinka.Text (SimpleMemberAccessExpression)
%11 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :84 :33) // "" (StringLiteralExpression)
%12 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :85 :12) // Not a variable of known type: txtBoxPotvrdaLozinke
%13 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :85 :12) // txtBoxPotvrdaLozinke.Text (SimpleMemberAccessExpression)
%14 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :85 :40) // "" (StringLiteralExpression)
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: PopuniComboBoxUloga
%15 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajKorisnika.cs" :86 :12) // PopuniComboBoxUloga() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
// Skipping function PopuniComboBoxUloga(), it contains poisonous unsupported syntaxes

// Skipping function ProvjeraUnosa(), it contains poisonous unsupported syntaxes

// Skipping function DohvatiSifruUloge(), it contains poisonous unsupported syntaxes

