func @_RegistarAutomobila.Forme.A.17Euriranje.FrmAzuriranjeMarke.AzurirajMarku$$() -> () loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :42 :8) {
^entry :
br ^0

^0: // BinaryBranchBlock
%0 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :44 :47) // new MarkaAutomobila()              {                  Id = this.ŠifraSelektiraneMarke,                  Naziv = this.NazivSelektiraneMarke,                  Drzava = this.DrzavaSelektiraneMarke              } (ObjectCreationExpression)
%1 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :46 :21) // this (ThisExpression)
%2 = cbde.unknown : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :46 :21) // this.ŠifraSelektiraneMarke (SimpleMemberAccessExpression)
%3 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :47 :24) // this (ThisExpression)
%4 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :47 :24) // this.NazivSelektiraneMarke (SimpleMemberAccessExpression)
%5 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :48 :25) // this (ThisExpression)
%6 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :48 :25) // this.DrzavaSelektiraneMarke (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :51 :33) // Not a variable of known type: db
%9 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :51 :33) // db.MarkaAutomobila (SimpleMemberAccessExpression)
%10 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :51 :57) // Not a variable of known type: selektiranaMarka
%11 = cbde.unknown : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :51 :57) // selektiranaMarka.Id (SimpleMemberAccessExpression)
%12 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :51 :33) // db.MarkaAutomobila.Find(selektiranaMarka.Id) (InvocationExpression)
%14 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :54 :16) // Not a variable of known type: postojecaMarka
%15 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :54 :16) // postojecaMarka.Naziv (SimpleMemberAccessExpression)
%16 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :54 :40) // Not a variable of known type: txtBoxNaziv
%17 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :54 :40) // txtBoxNaziv.Text (SimpleMemberAccessExpression)
%18 = cbde.unknown : i1  loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :54 :16) // comparison of unknown type: postojecaMarka.Naziv != txtBoxNaziv.Text
cond_br %18, ^1, ^2 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :54 :16)

^1: // SimpleBlock
%19 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :56 :16) // Not a variable of known type: postojecaMarka
%20 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :56 :16) // postojecaMarka.Naziv (SimpleMemberAccessExpression)
%21 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :56 :39) // Not a variable of known type: txtBoxNaziv
%22 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :56 :39) // txtBoxNaziv.Text (SimpleMemberAccessExpression)
br ^2

^2: // BinaryBranchBlock
%23 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :58 :16) // Not a variable of known type: postojecaMarka
%24 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :58 :16) // postojecaMarka.Drzava (SimpleMemberAccessExpression)
%25 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :58 :41) // Not a variable of known type: txtBoxDrzava
%26 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :58 :41) // txtBoxDrzava.Text (SimpleMemberAccessExpression)
%27 = cbde.unknown : i1  loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :58 :16) // comparison of unknown type: postojecaMarka.Drzava != txtBoxDrzava.Text
cond_br %27, ^3, ^4 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :58 :16)

^3: // SimpleBlock
%28 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :60 :16) // Not a variable of known type: postojecaMarka
%29 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :60 :16) // postojecaMarka.Drzava (SimpleMemberAccessExpression)
%30 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :60 :40) // Not a variable of known type: txtBoxDrzava
%31 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :60 :40) // txtBoxDrzava.Text (SimpleMemberAccessExpression)
br ^4

^4: // SimpleBlock
%32 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :62 :12) // Not a variable of known type: db
%33 = cbde.unknown : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :62 :12) // db.SaveChanges() (InvocationExpression)
br ^5

^5: // ExitBlock
return

}
// Skipping function btnSpremi_Click(none, none), it contains poisonous unsupported syntaxes

func @_RegistarAutomobila.Forme.A.17Euriranje.FrmAzuriranjeMarke.btnNatrag_Click$object.System.EventArgs$(none, none) -> () loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :104 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :104 :37)
cbde.store %_sender, %0 : memref<none> loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :104 :37)
%1 = cbde.alloca none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :104 :52)
cbde.store %_e, %1 : memref<none> loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :104 :52)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :106 :12) // this (ThisExpression)
%3 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :106 :12) // this.Hide() (InvocationExpression)
%4 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :107 :39) // new FrmMarkeAutomobila() (ObjectCreationExpression)
%6 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :108 :12) // Not a variable of known type: forma
%7 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :108 :12) // forma.ShowDialog() (InvocationExpression)
%8 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :109 :12) // this (ThisExpression)
%9 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeMarke.cs" :109 :12) // this.Close() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
// Skipping function ProvjeraUnosa(), it contains poisonous unsupported syntaxes

