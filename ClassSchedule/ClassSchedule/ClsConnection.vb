Imports System.Data
Imports System.Data.SqlClient

Public Class ClsConnection

    Dim objconnection As New SqlConnection("SERVER = (local); DATABASE = ClassSchedule; INTEGRATED SECURITY = True;")
    
End Class
