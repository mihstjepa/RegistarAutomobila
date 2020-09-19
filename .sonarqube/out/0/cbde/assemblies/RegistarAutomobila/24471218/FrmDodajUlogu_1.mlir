func @_RegistarAutomobila.Forme.Dodavanje.FrmDodajUlogu.btnSpremi_Click$object.System.EventArgs$(none, none) -> () loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :31 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :31 :37)
cbde.store %_sender, %0 : memref<none> loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :31 :37)
%1 = cbde.alloca none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :31 :52)
cbde.store %_e, %1 : memref<none> loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :31 :52)
br ^0

^0: // BinaryBranchBlock
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: ProvjeraUnosa
%2 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :33 :28) // ProvjeraUnosa() (InvocationExpression)
%4 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :35 :16) // Not a variable of known type: poruka
%5 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :35 :26) // "" (StringLiteralExpression)
%6 = cbde.unknown : i1  loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :35 :16) // comparison of unknown type: poruka == ""
cond_br %6, ^1, ^2 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :35 :16)

^1: // SimpleBlock
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: SpremiNovuUlogu
%7 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :37 :16) // SpremiNovuUlogu() (InvocationExpression)
// Entity from another assembly: MessageBox
%8 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :38 :32) // "Uspješan unos!" (StringLiteralExpression)
%9 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :38 :16) // MessageBox.Show("Uspješan unos!") (InvocationExpression)
%10 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :40 :16) // this (ThisExpression)
%11 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :40 :16) // this.Hide() (InvocationExpression)
%12 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :41 :33) // new FrmUloge() (ObjectCreationExpression)
%14 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :42 :16) // Not a variable of known type: forma
%15 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :42 :16) // forma.ShowDialog() (InvocationExpression)
%16 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :43 :16) // this (ThisExpression)
%17 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :43 :16) // this.Close() (InvocationExpression)
br ^3

^2: // SimpleBlock
// Entity from another assembly: MessageBox
%18 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :47 :32) // Not a variable of known type: poruka
%19 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :47 :16) // MessageBox.Show(poruka) (InvocationExpression)
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: OsvjeziPrikaz
%20 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :48 :16) // OsvjeziPrikaz() (InvocationExpression)
br ^3

^3: // ExitBlock
return

}
func @_RegistarAutomobila.Forme.Dodavanje.FrmDodajUlogu.btnNatrag_Click$object.System.EventArgs$(none, none) -> () loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :57 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :57 :37)
cbde.store %_sender, %0 : memref<none> loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :57 :37)
%1 = cbde.alloca none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :57 :52)
cbde.store %_e, %1 : memref<none> loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :57 :52)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :59 :12) // this (ThisExpression)
%3 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :59 :12) // this.Hide() (InvocationExpression)
%4 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :60 :29) // new FrmUloge() (ObjectCreationExpression)
%6 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :61 :12) // Not a variable of known type: forma
%7 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :61 :12) // forma.ShowDialog() (InvocationExpression)
%8 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :62 :12) // this (ThisExpression)
%9 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :62 :12) // this.Close() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_RegistarAutomobila.Forme.Dodavanje.FrmDodajUlogu.OsvjeziPrikaz$$() -> () loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :69 :8) {
^entry :
br ^0

^0: // SimpleBlock
%0 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :71 :12) // Not a variable of known type: txtBoxNazivUloge
%1 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :71 :12) // txtBoxNazivUloge.Text (SimpleMemberAccessExpression)
%2 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :71 :36) // "" (StringLiteralExpression)
br ^1

^1: // ExitBlock
return

}
// Skipping function ProvjeraUnosa(), it contains poisonous unsupported syntaxes

func @_RegistarAutomobila.Forme.Dodavanje.FrmDodajUlogu.SpremiNovuUlogu$$() -> () loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :109 :8) {
^entry :
br ^0

^0: // SimpleBlock
%0 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :111 :30) // new Uloga()              {                  Naziv = txtBoxNazivUloge.Text              } (ObjectCreationExpression)
%1 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :113 :24) // Not a variable of known type: txtBoxNazivUloge
%2 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :113 :24) // txtBoxNazivUloge.Text (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :116 :12) // Not a variable of known type: db
%5 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :116 :12) // db.Uloga (SimpleMemberAccessExpression)
%6 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :116 :25) // Not a variable of known type: novaUloga
%7 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :116 :12) // db.Uloga.Add(novaUloga) (InvocationExpression)
%8 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :117 :12) // Not a variable of known type: db
%9 = cbde.unknown : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajUlogu.cs" :117 :12) // db.SaveChanges() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
