Imports MySql.Data.MySqlClient

Public Class Course_form
    Dim conn As New MySqlConnection("host=localhost; user=root;password=root;database=project")
    'this is the beginning of the loadCourse code
    Public num As String

    Public Sub loadListViewCourses()

        Dim dbQuery As String
        dbQuery = "SELECT * FROM project.student_table"
        regCourses.Items.Clear()


        Dim dbAdapter As New MySqlDataAdapter
        Dim dbCommand As New MySqlCommand
        Dim TABLE As New DataTable
        Dim i As Integer
        With dbCommand
            .CommandText = dbQuery
            .Connection = conn
        End With

        With dbAdapter
            .SelectCommand = dbCommand
            .Fill(TABLE)
        End With

        For i = 0 To TABLE.Rows.Count - 1

            With regCourses
                .Items.Add(TABLE.Rows(i)("Course_Code"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("Course_Title"))
                    .Add(TABLE.Rows(i)("Course_Unit"))
                    .Add(TABLE.Rows(i)("Semester"))
                End With
            End With
        Next
    End Sub
    'this is the end of the loadCourse Code

    Private Sub CourseRegistrationListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles regCourses.SelectedIndexChanged

    End Sub

    Private Sub Course_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        num = Student_Info_form.RegistrationNum
        TextBox1.Text = num
        TextBox2.Text = Student_Info_form.sName + Student_Info_form.oNames
        TextBox3.Text = Student_Info_form.selProgg
        TextBox4.Text = Form1.session

        If conn.State = ConnectionState.Closed Then
            conn.ConnectionString = "host = localhost; user = root; password = root; database = project;"
            conn.Open()
        End If
        loadListViewCourses()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class