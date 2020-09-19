func @_RegistarAutomobila.Forme.A.17Euriranje.FrmAzuriranjeUloge.btnNatrag_Click$object.System.EventArgs$(none, none) -> () loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :41 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :41 :37)
cbde.store %_sender, %0 : memref<none> loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :41 :37)
%1 = cbde.alloca none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :41 :52)
cbde.store %_e, %1 : memref<none> loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :41 :52)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :43 :12) // this (ThisExpression)
%3 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :43 :12) // this.Hide() (InvocationExpression)
%4 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :44 :29) // new FrmUloge() (ObjectCreationExpression)
%6 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :45 :12) // Not a variable of known type: forma
%7 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :45 :12) // forma.ShowDialog() (InvocationExpression)
%8 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :46 :12) // this (ThisExpression)
%9 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :46 :12) // this.Close() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
// Skipping function btnSpremi_Click(none, none), it contains poisonous unsupported syntaxes

func @_RegistarAutomobila.Forme.A.17Euriranje.FrmAzuriranjeUloge.AzurirajUlogu$$() -> () loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :86 :8) {
^entry :
br ^0

^0: // SimpleBlock
%0 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :88 :41) // new Uloga()                  {                      Id = this.IdSelektiraneUloge,                      Naziv = this.NazivSelektiraneUloge                  } (ObjectCreationExpression)
%1 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :90 :25) // this (ThisExpression)
%2 = cbde.unknown : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :90 :25) // this.IdSelektiraneUloge (SimpleMemberAccessExpression)
%3 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :91 :28) // this (ThisExpression)
%4 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :91 :28) // this.NazivSelektiraneUloge (SimpleMemberAccessExpression)
%6 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :94 :37) // Not a variable of known type: db
%7 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :94 :37) // db.Uloga (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :94 :51) // Not a variable of known type: selektiranaUloga
%9 = cbde.unknown : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :94 :51) // selektiranaUloga.Id (SimpleMemberAccessExpression)
%10 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :94 :37) // db.Uloga.Find(selektiranaUloga.Id) (InvocationExpression)
%12 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :95 :16) // Not a variable of known type: postojecaUloga
%13 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :95 :16) // postojecaUloga.Naziv (SimpleMemberAccessExpression)
%14 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :95 :39) // Not a variable of known type: txtBoxNaziv
%15 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :95 :39) // txtBoxNaziv.Text (SimpleMemberAccessExpression)
%16 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :96 :16) // Not a variable of known type: db
%17 = cbde.unknown : i32 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Forme\\Ažuriranje\\FrmAzuriranjeUloge.cs" :96 :16) // db.SaveChanges() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
// Skipping function ProvjeraUnosa(), it contains poisonous unsupported syntaxes

