Imports System.Data.OleDb

Module Module1
    Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\iffah\source\repos\omc-18\omc 18\bin\Debug\Atelier.accdb")

    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New Form8())

    End Sub

End Module
