func @_RegistarAutomobila.Forme.Dodavanje.FrmDodajModel.btnNatrag_Click$object.System.EventArgs$(none, none) -> () loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :26 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :26 :37)
cbde.store %_sender, %0 : memref<none> loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :26 :37)
%1 = cbde.alloca none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :26 :52)
cbde.store %_e, %1 : memref<none> loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :26 :52)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :28 :12) // this (ThisExpression)
%3 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :28 :12) // this.Hide() (InvocationExpression)
%4 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :29 :40) // new FrmModeliAutomobila() (ObjectCreationExpression)
%6 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :30 :12) // Not a variable of known type: forma
%7 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :30 :12) // forma.ShowDialog() (InvocationExpression)
%8 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :31 :12) // this (ThisExpression)
%9 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :31 :12) // this.Close() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_RegistarAutomobila.Forme.Dodavanje.FrmDodajModel.OsvjeziPrikaz$$() -> () loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :38 :8) {
^entry :
br ^0

^0: // SimpleBlock
%0 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :40 :12) // Not a variable of known type: txtBoxNaziv
%1 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :40 :12) // txtBoxNaziv.Text (SimpleMemberAccessExpression)
%2 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :40 :31) // "" (StringLiteralExpression)
%3 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :41 :12) // Not a variable of known type: txtBoxGodinaProizvodnje
%4 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :41 :12) // txtBoxGodinaProizvodnje.Text (SimpleMemberAccessExpression)
%5 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :41 :43) // "" (StringLiteralExpression)
%6 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :42 :12) // Not a variable of known type: txtBoxCijena
%7 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :42 :12) // txtBoxCijena.Text (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :42 :32) // "" (StringLiteralExpression)
%9 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :43 :12) // Not a variable of known type: txtBoxSnagaMotora
%10 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :43 :12) // txtBoxSnagaMotora.Text (SimpleMemberAccessExpression)
%11 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :43 :37) // "" (StringLiteralExpression)
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: PopuniComboBoxMarka
%12 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :44 :12) // PopuniComboBoxMarka() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
// Skipping function PopuniComboBoxMarka(), it contains poisonous unsupported syntaxes

func @_RegistarAutomobila.Forme.Dodavanje.FrmDodajModel.ProvjeraUnosa$$() -> none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :68 :8) {
^entry :
br ^0

^0: // BinaryBranchBlock
%0 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :70 :28) // "" (StringLiteralExpression)
%2 = cbde.alloca i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :71 :16) // godinaProizvodnje
%4 = cbde.alloca i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :73 :16) // snagaMotora
// Entity from another assembly: String
%5 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :76 :37) // Not a variable of known type: txtBoxNaziv
%6 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :76 :37) // txtBoxNaziv.Text (SimpleMemberAccessExpression)
%7 = cbde.unknown : i1 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :76 :16) // String.IsNullOrEmpty(txtBoxNaziv.Text) (InvocationExpression)
cond_br %7, ^1, ^2 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :76 :16)

^1: // SimpleBlock
%8 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :78 :25) // Not a variable of known type: poruka
%9 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :78 :34) // $"Nije unesen naziv!\r\n" (InterpolatedStringExpression)
%10 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :78 :25) // Binary expression on unsupported types poruka + $"Nije unesen naziv!\r\n"
br ^3

^2: // BinaryBranchBlock
%11 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :80 :21) // Not a variable of known type: txtBoxNaziv
%12 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :80 :21) // txtBoxNaziv.Text (SimpleMemberAccessExpression)
%13 = cbde.unknown : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :80 :21) // txtBoxNaziv.Text.Length (SimpleMemberAccessExpression)
%14 = constant 50 : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :80 :47)
%15 = cmpi "sgt", %13, %14 : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :80 :21)
cond_br %15, ^4, ^3 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :80 :21)

^4: // SimpleBlock
%16 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :82 :25) // Not a variable of known type: poruka
%17 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :82 :34) // $"Naziv smije imati maksimalno 50 znakova!\r\n" (InterpolatedStringExpression)
%18 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :82 :25) // Binary expression on unsupported types poruka + $"Naziv smije imati maksimalno 50 znakova!\r\n"
br ^3

^3: // BinaryBranchBlock
// Entity from another assembly: String
%19 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :86 :37) // Not a variable of known type: txtBoxGodinaProizvodnje
%20 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :86 :37) // txtBoxGodinaProizvodnje.Text (SimpleMemberAccessExpression)
%21 = cbde.unknown : i1 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :86 :16) // String.IsNullOrEmpty(txtBoxGodinaProizvodnje.Text) (InvocationExpression)
cond_br %21, ^5, ^6 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :86 :16)

^5: // SimpleBlock
%22 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :88 :25) // Not a variable of known type: poruka
%23 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :88 :34) // $"Nije unesena godina proizvodnje!\r\n" (InterpolatedStringExpression)
%24 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :88 :25) // Binary expression on unsupported types poruka + $"Nije unesena godina proizvodnje!\r\n"
br ^7

^6: // BinaryBranchBlock
%25 = cbde.unknown : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :90 :22) // int (PredefinedType)
%26 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :90 :35) // Not a variable of known type: txtBoxGodinaProizvodnje
%27 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :90 :35) // txtBoxGodinaProizvodnje.Text (SimpleMemberAccessExpression)
%28 = cbde.load %2 : memref<i32> loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :90 :69)
%29 = cbde.unknown : i1 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :90 :22) // int.TryParse(txtBoxGodinaProizvodnje.Text, out godinaProizvodnje) (InvocationExpression)
%30 = cbde.unknown : i1 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :90 :21) // !int.TryParse(txtBoxGodinaProizvodnje.Text, out godinaProizvodnje) (LogicalNotExpression)
cond_br %30, ^8, ^9 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :90 :21)

^8: // SimpleBlock
%31 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :92 :25) // Not a variable of known type: poruka
%32 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :92 :34) // $"Godina proizvodnje mora biti cijeli broj!\r\n" (InterpolatedStringExpression)
%33 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :92 :25) // Binary expression on unsupported types poruka + $"Godina proizvodnje mora biti cijeli broj!\r\n"
br ^7

^9: // BinaryBranchBlock
%34 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :94 :21) // Not a variable of known type: txtBoxGodinaProizvodnje
%35 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :94 :21) // txtBoxGodinaProizvodnje.Text (SimpleMemberAccessExpression)
%36 = cbde.unknown : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :94 :21) // txtBoxGodinaProizvodnje.Text.Length (SimpleMemberAccessExpression)
%37 = constant 4 : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :94 :60)
%38 = cmpi "ne", %36, %37 : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :94 :21)
cond_br %38, ^10, ^7 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :94 :21)

^10: // SimpleBlock
%39 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :96 :25) // Not a variable of known type: poruka
%40 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :96 :34) // $"Unesena godina mora imati točno 4 znamenke!\r\n" (InterpolatedStringExpression)
%41 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :96 :25) // Binary expression on unsupported types poruka + $"Unesena godina mora imati točno 4 znamenke!\r\n"
br ^7

^7: // BinaryBranchBlock
// Entity from another assembly: String
%42 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :100 :37) // Not a variable of known type: txtBoxCijena
%43 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :100 :37) // txtBoxCijena.Text (SimpleMemberAccessExpression)
%44 = cbde.unknown : i1 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :100 :16) // String.IsNullOrEmpty(txtBoxCijena.Text) (InvocationExpression)
cond_br %44, ^11, ^12 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :100 :16)

^11: // SimpleBlock
%45 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :102 :25) // Not a variable of known type: poruka
%46 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :102 :34) // $"Nije unesena cijena!\r\n" (InterpolatedStringExpression)
%47 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :102 :25) // Binary expression on unsupported types poruka + $"Nije unesena cijena!\r\n"
br ^13

^12: // BinaryBranchBlock
%48 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :104 :22) // decimal (PredefinedType)
%49 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :104 :39) // Not a variable of known type: txtBoxCijena
%50 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :104 :39) // txtBoxCijena.Text (SimpleMemberAccessExpression)
%51 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :104 :62) // Not a variable of known type: cijena
%52 = cbde.unknown : i1 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :104 :22) // decimal.TryParse(txtBoxCijena.Text, out cijena) (InvocationExpression)
%53 = cbde.unknown : i1 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :104 :21) // !decimal.TryParse(txtBoxCijena.Text, out cijena) (LogicalNotExpression)
cond_br %53, ^14, ^15 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :104 :21)

^14: // SimpleBlock
%54 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :106 :25) // Not a variable of known type: poruka
%55 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :106 :34) // $"Cijena mora biti decimalan broj u formatu 0.00!\r\n" (InterpolatedStringExpression)
%56 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :106 :25) // Binary expression on unsupported types poruka + $"Cijena mora biti decimalan broj u formatu 0.00!\r\n"
br ^13

^15: // BinaryBranchBlock
%57 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :108 :21) // decimal (PredefinedType)
%58 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :108 :35) // Not a variable of known type: txtBoxCijena
%59 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :108 :35) // txtBoxCijena.Text (SimpleMemberAccessExpression)
%60 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :108 :21) // decimal.Parse(txtBoxCijena.Text) (InvocationExpression)
%61 = constant unit loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :108 :56) // 999999999999999999 (NumericLiteralExpression)
%62 = cbde.unknown : i1  loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :108 :21) // comparison of unknown type: decimal.Parse(txtBoxCijena.Text) > 999999999999999999
cond_br %62, ^16, ^13 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :108 :21)

^16: // SimpleBlock
%63 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :110 :25) // Not a variable of known type: poruka
%64 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :110 :34) // $"Cijena mora biti manji iznos!\r\n" (InterpolatedStringExpression)
%65 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :110 :25) // Binary expression on unsupported types poruka + $"Cijena mora biti manji iznos!\r\n"
br ^13

^13: // BinaryBranchBlock
// Entity from another assembly: String
%66 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :114 :37) // Not a variable of known type: txtBoxSnagaMotora
%67 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :114 :37) // txtBoxSnagaMotora.Text (SimpleMemberAccessExpression)
%68 = cbde.unknown : i1 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :114 :16) // String.IsNullOrEmpty(txtBoxSnagaMotora.Text) (InvocationExpression)
cond_br %68, ^17, ^18 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :114 :16)

^17: // SimpleBlock
%69 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :116 :25) // Not a variable of known type: poruka
%70 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :116 :34) // $"Nije unesena snaga motora!\r\n" (InterpolatedStringExpression)
%71 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :116 :25) // Binary expression on unsupported types poruka + $"Nije unesena snaga motora!\r\n"
br ^19

^18: // BinaryBranchBlock
%72 = cbde.unknown : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :118 :22) // int (PredefinedType)
%73 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :118 :35) // Not a variable of known type: txtBoxSnagaMotora
%74 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :118 :35) // txtBoxSnagaMotora.Text (SimpleMemberAccessExpression)
%75 = cbde.load %4 : memref<i32> loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :118 :63)
%76 = cbde.unknown : i1 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :118 :22) // int.TryParse(txtBoxSnagaMotora.Text, out snagaMotora) (InvocationExpression)
%77 = cbde.unknown : i1 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :118 :21) // !int.TryParse(txtBoxSnagaMotora.Text, out snagaMotora) (LogicalNotExpression)
cond_br %77, ^20, ^21 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :118 :21)

^20: // SimpleBlock
%78 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :120 :25) // Not a variable of known type: poruka
%79 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :120 :34) // $"Snaga motora mora biti cijeli broj!\r\n" (InterpolatedStringExpression)
%80 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :120 :25) // Binary expression on unsupported types poruka + $"Snaga motora mora biti cijeli broj!\r\n"
br ^19

^21: // BinaryBranchBlock
%81 = cbde.unknown : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :122 :21) // int (PredefinedType)
%82 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :122 :31) // Not a variable of known type: txtBoxSnagaMotora
%83 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :122 :31) // txtBoxSnagaMotora.Text (SimpleMemberAccessExpression)
%84 = cbde.unknown : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :122 :21) // int.Parse(txtBoxSnagaMotora.Text) (InvocationExpression)
%85 = constant 10000 : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :122 :57)
%86 = cmpi "sgt", %84, %85 : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :122 :21)
cond_br %86, ^22, ^19 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :122 :21)

^22: // SimpleBlock
%87 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :124 :25) // Not a variable of known type: poruka
%88 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :124 :34) // $"Snaga motora mora biti manji broj!\r\n" (InterpolatedStringExpression)
%89 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :124 :25) // Binary expression on unsupported types poruka + $"Snaga motora mora biti manji broj!\r\n"
br ^19

^19: // JumpBlock
%90 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :127 :19) // Not a variable of known type: poruka
return %90 : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :127 :12)

^23: // ExitBlock
cbde.unreachable

}
// Skipping function DohvatiIdMarke(), it contains poisonous unsupported syntaxes

func @_RegistarAutomobila.Forme.Dodavanje.FrmDodajModel.btnSpremi_Click_1$object.System.EventArgs$(none, none) -> () loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :160 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :160 :39)
cbde.store %_sender, %0 : memref<none> loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :160 :39)
%1 = cbde.alloca none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :160 :54)
cbde.store %_e, %1 : memref<none> loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :160 :54)
br ^0

^0: // BinaryBranchBlock
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: ProvjeraUnosa
%2 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :162 :28) // ProvjeraUnosa() (InvocationExpression)
%4 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :163 :16) // Not a variable of known type: poruka
%5 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :163 :26) // "" (StringLiteralExpression)
%6 = cbde.unknown : i1  loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :163 :16) // comparison of unknown type: poruka != ""
cond_br %6, ^1, ^2 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :163 :16)

^1: // SimpleBlock
// Entity from another assembly: MessageBox
%7 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :165 :32) // Not a variable of known type: poruka
%8 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :165 :16) // MessageBox.Show(poruka) (InvocationExpression)
br ^3

^2: // SimpleBlock
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: SpremiNoviModel
%9 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :169 :16) // SpremiNoviModel() (InvocationExpression)
// Entity from another assembly: MessageBox
%10 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :170 :32) // "Uspješan unos!" (StringLiteralExpression)
%11 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :170 :16) // MessageBox.Show("Uspješan unos!") (InvocationExpression)
%12 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :172 :16) // this (ThisExpression)
%13 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :172 :16) // this.Hide() (InvocationExpression)
%14 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :173 :44) // new FrmModeliAutomobila() (ObjectCreationExpression)
%16 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :174 :16) // Not a variable of known type: forma
%17 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :174 :16) // forma.ShowDialog() (InvocationExpression)
%18 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :175 :16) // this (ThisExpression)
%19 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :175 :16) // this.Close() (InvocationExpression)
br ^3

^3: // ExitBlock
return

}
func @_RegistarAutomobila.Forme.Dodavanje.FrmDodajModel.SpremiNoviModel$$() -> () loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :182 :8) {
^entry :
br ^0

^0: // SimpleBlock
%0 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :184 :40) // new ModelAutomobila()              {                  Naziv = txtBoxNaziv.Text,                  GodinaProizvodnje = int.Parse(txtBoxGodinaProizvodnje.Text),                  SnagaMotora = int.Parse(txtBoxSnagaMotora.Text),                  Cijena = decimal.Parse(txtBoxCijena.Text),                  MarkaAutomobilaId = DohvatiIdMarke(),                  KorisnikId = LoginPodaci.Id              } (ObjectCreationExpression)
%1 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :186 :24) // Not a variable of known type: txtBoxNaziv
%2 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :186 :24) // txtBoxNaziv.Text (SimpleMemberAccessExpression)
%3 = cbde.unknown : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :187 :36) // int (PredefinedType)
%4 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :187 :46) // Not a variable of known type: txtBoxGodinaProizvodnje
%5 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :187 :46) // txtBoxGodinaProizvodnje.Text (SimpleMemberAccessExpression)
%6 = cbde.unknown : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :187 :36) // int.Parse(txtBoxGodinaProizvodnje.Text) (InvocationExpression)
%7 = cbde.unknown : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :188 :30) // int (PredefinedType)
%8 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :188 :40) // Not a variable of known type: txtBoxSnagaMotora
%9 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :188 :40) // txtBoxSnagaMotora.Text (SimpleMemberAccessExpression)
%10 = cbde.unknown : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :188 :30) // int.Parse(txtBoxSnagaMotora.Text) (InvocationExpression)
%11 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :189 :25) // decimal (PredefinedType)
%12 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :189 :39) // Not a variable of known type: txtBoxCijena
%13 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :189 :39) // txtBoxCijena.Text (SimpleMemberAccessExpression)
%14 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :189 :25) // decimal.Parse(txtBoxCijena.Text) (InvocationExpression)
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: DohvatiIdMarke
%15 = cbde.unknown : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :190 :36) // DohvatiIdMarke() (InvocationExpression)
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: LoginPodaci
%16 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :191 :29) // LoginPodaci.Id (SimpleMemberAccessExpression)
%18 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :194 :12) // Not a variable of known type: db
%19 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :194 :12) // db.ModelAutomobila (SimpleMemberAccessExpression)
%20 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :194 :35) // Not a variable of known type: noviModel
%21 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :194 :12) // db.ModelAutomobila.Add(noviModel) (InvocationExpression)
%22 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :195 :12) // Not a variable of known type: db
%23 = cbde.unknown : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Dodavanje\\FrmDodajModel.cs" :195 :12) // db.SaveChanges() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
