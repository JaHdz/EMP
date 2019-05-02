Imports System.Data.SqlClient
Imports System.Threading

Module Connections
    Dim Count As Integer = 0
    Private LastConn As String = String.Empty
    Private ReadOnly ConnectionPool As New Dictionary(Of String, String) From {
        {"Developer1", "Data Source=MX1018-PF15YZS7;Initial Catalog=EmpleadosDB;Integrated Security=True"},'XAVI
        {"Developer2", "Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=EmpleadosDB;Integrated Security=True"}'STEPH
    }
    Private TestedConnections As New Dictionary(Of String, String)
    Public Function ConnectionString() As String
        If LastConn = String.Empty Then
            If Debugger.IsAttached() Then
                For Each kvp As KeyValuePair(Of String, String) In ConnectionPool
                    Dim ltThread = New Thread(AddressOf TryConnection)
                    ltThread.Start(kvp.Value)
                    Thread.Sleep(500)
                Next
            Else
                LastConn = My.Settings.DBConnectionString
            End If
        End If
        Return LastConn
    End Function
    Public Sub TryConnection(CurrentDbTesting As String)
        Using Conn As New SqlConnection(CurrentDbTesting)
            Try
                Conn.Open()
                LastConn = CurrentDbTesting
            Catch ex As Exception
            End Try
        End Using
    End Sub
End Module
