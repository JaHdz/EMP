Imports System.Data.SqlClient
Imports System.Threading

Friend Module Connections
    Private LastConn As String = String.Empty
    Private ReadOnly DeveloperConnectionPool As New Dictionary(Of String, String) From {
        {"Developer1", "Data Source=MX1018-PF15YZS7;Initial Catalog=EmpleadosDB;Integrated Security=True;"},'XAVI
        {"Developer2", "Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=EmpleadosDB;Integrated Security=True;"}'STEPH
    }
    Private ReadOnly RuntimeConnections As New Dictionary(Of String, String) From {
        {"Production", "Data Source=TURING;Initial Catalog=EmpleadosDB;User ID=developer;Integrated Security=True;"}'Production DB    
    }
    Public Function ConnectionString() As String
        If LastConn = String.Empty Then
            If Debugger.IsAttached() Then
                For Each kvp As KeyValuePair(Of String, String) In DeveloperConnectionPool
                    Dim ltThread = New Thread(AddressOf TryConnection)
                    ltThread.Start(kvp.Value)
                    Thread.Sleep(500)
                Next
            Else
                LastConn = RuntimeConnections("Production")
                My.Settings.DBConnectionString = LastConn
                My.Settings.Save()
            End If
        End If
        Return LastConn
    End Function
    Public Sub TryConnection(CurrentDbTesting As String)
        Using Conn As New SqlConnection(CurrentDbTesting)
            Try
                Conn.Open()
                LastConn = CurrentDbTesting
                My.Settings.DBConnectionString = LastConn
                My.Settings.Save()
            Catch ex As Exception
            End Try
        End Using
    End Sub
End Module
