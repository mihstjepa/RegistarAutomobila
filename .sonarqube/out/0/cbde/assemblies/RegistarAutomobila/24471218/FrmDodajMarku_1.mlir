func @_RegistarAutomobila.Forme.Dodavanje.FrmDodajMarku.btnSpremi_Click$object.System.EventArgs$(none, none) -> () loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :31 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :31 :37)
cbde.store %_sender, %0 : memref<none> loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :31 :37)
%1 = cbde.alloca none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :31 :52)
cbde.store %_e, %1 : memref<none> loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :31 :52)
br ^0

^0: // BinaryBranchBlock
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: ProvjeraUnosa
%2 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :33 :28) // ProvjeraUnosa() (InvocationExpression)
%4 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :34 :16) // Not a variable of known type: poruka
%5 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :34 :26) // "" (StringLiteralExpression)
%6 = cbde.unknown : i1  loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :34 :16) // comparison of unknown type: poruka != ""
cond_br %6, ^1, ^2 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :34 :16)

^1: // SimpleBlock
// Entity from another assembly: MessageBox
%7 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :36 :32) // Not a variable of known type: poruka
%8 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :36 :16) // MessageBox.Show(poruka) (InvocationExpression)
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: OsvježiPrikaz
%9 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :37 :16) // OsvježiPrikaz() (InvocationExpression)
br ^3

^2: // SimpleBlock
%10 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :41 :44) // new MarkaAutomobila()                  {                      Naziv = txtBoxNaziv.Text,                      Drzava = txtBoxDrzava.Text                  } (ObjectCreationExpression)
%11 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :43 :28) // Not a variable of known type: txtBoxNaziv
%12 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :43 :28) // txtBoxNaziv.Text (SimpleMemberAccessExpression)
%13 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :44 :29) // Not a variable of known type: txtBoxDrzava
%14 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :44 :29) // txtBoxDrzava.Text (SimpleMemberAccessExpression)
%16 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :47 :16) // Not a variable of known type: db
%17 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :47 :16) // db.MarkaAutomobila (SimpleMemberAccessExpression)
%18 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :47 :39) // Not a variable of known type: novaMarka
%19 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :47 :16) // db.MarkaAutomobila.Add(novaMarka) (InvocationExpression)
%20 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :48 :16) // Not a variable of known type: db
%21 = cbde.unknown : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :48 :16) // db.SaveChanges() (InvocationExpression)
// Entity from another assembly: MessageBox
%22 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :49 :32) // "Uspješan unos!" (StringLiteralExpression)
%23 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :49 :16) // MessageBox.Show("Uspješan unos!") (InvocationExpression)
%24 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :51 :16) // this (ThisExpression)
%25 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :51 :16) // this.Hide() (InvocationExpression)
%26 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :52 :43) // new FrmMarkeAutomobila() (ObjectCreationExpression)
%28 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :53 :16) // Not a variable of known type: forma
%29 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :53 :16) // forma.ShowDialog() (InvocationExpression)
%30 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :54 :16) // this (ThisExpression)
%31 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :54 :16) // this.Close() (InvocationExpression)
br ^3

^3: // ExitBlock
return

}
func @_RegistarAutomobila.Forme.Dodavanje.FrmDodajMarku.btnNatrag_Click$object.System.EventArgs$(none, none) -> () loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :63 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :63 :37)
cbde.store %_sender, %0 : memref<none> loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :63 :37)
%1 = cbde.alloca none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :63 :52)
cbde.store %_e, %1 : memref<none> loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :63 :52)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :65 :12) // this (ThisExpression)
%3 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :65 :12) // this.Hide() (InvocationExpression)
%4 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :66 :44) // new FrmMarkeAutomobila() (ObjectCreationExpression)
%6 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :67 :12) // Not a variable of known type: formaMarke
%7 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :67 :12) // formaMarke.ShowDialog() (InvocationExpression)
%8 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :68 :12) // this (ThisExpression)
%9 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :68 :12) // this.Close() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_RegistarAutomobila.Forme.Dodavanje.FrmDodajMarku.Osvje.17EiPrikaz$$() -> () loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :74 :8) {
^entry :
br ^0

^0: // SimpleBlock
%0 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :76 :12) // Not a variable of known type: txtBoxDrzava
%1 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :76 :12) // txtBoxDrzava.Text (SimpleMemberAccessExpression)
%2 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :76 :32) // "" (StringLiteralExpression)
%3 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :77 :12) // Not a variable of known type: txtBoxNaziv
%4 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :77 :12) // txtBoxNaziv.Text (SimpleMemberAccessExpression)
%5 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajMarku.cs" :77 :31) // "" (StringLiteralExpression)
br ^1

^1: // ExitBlock
return

}
// Skipping function ProvjeraUnosa(), it contains poisonous unsupported syntaxes

