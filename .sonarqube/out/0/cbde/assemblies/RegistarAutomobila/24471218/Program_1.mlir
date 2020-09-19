func @_RegistarAutomobila.Program.Main$$() -> () loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Program.cs" :15 :8) {
^entry :
br ^0

^0: // SimpleBlock
// Entity from another assembly: Application
%0 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Program.cs" :18 :12) // Application.EnableVisualStyles() (InvocationExpression)
// Entity from another assembly: Application
%1 = constant 0 : i1 loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Program.cs" :19 :58) // false
%2 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Program.cs" :19 :12) // Application.SetCompatibleTextRenderingDefault(false) (InvocationExpression)
// Entity from another assembly: Application
%3 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Program.cs" :20 :28) // new FrmPrijava() (ObjectCreationExpression)
%4 = cbde.unknown : none loc("C:\\PROJEKTI\\RegistarAutomobila\\RegistarAutomobila\\RegistarAutomobila\\Program.cs" :20 :12) // Application.Run(new FrmPrijava()) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
