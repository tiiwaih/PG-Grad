Imports MySql.Data.MySqlClient

Public Class Form2
    Public sConnection As New MySqlConnection
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If sConnection.State = ConnectionState.Closed Then
            sConnection.ConnectionString = "host = localhost; user = root; password = root; database = project;"
            sConnection.Open()
        End If

        loadCompulsoryCourses()

    End Sub

    Public Sub loadCompulsoryCourses()
        Dim dbQuery As String = "SELECT * FROM compulsory_courses"
        Dim dbAdapter As New MySqlDataAdapter
        Dim dbCommand As New MySqlCommand
        Dim TABLE As New DataTable
        Dim i As Integer
        With dbCommand
            .CommandText = dbQuery
            .Connection = sConnection
        End With

        With dbAdapter
            .SelectCommand = dbCommand
            .Fill(TABLE)
        End With

        For i = 0 To TABLE.Rows.Count - 1
            CourseRegistrationListView.CheckBoxes = True
            With CourseRegistrationListView
                .Items.Add(TABLE.Rows(i)("Course_Code"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("Course_Title"))
                    .Add(TABLE.Rows(i)("Course_Unit"))
                    .Add(TABLE.Rows(i)("Semester"))
                End With
            End With
        Next
    End Sub
End Class