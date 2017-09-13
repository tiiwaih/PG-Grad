Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As New MySqlConnection("host=localhost; user=root;password=root;database=project")
    Dim cmd As New MySqlCommand
    Dim dtr As MySqlDataReader
    Dim TABLE As New DataTable
    Public session As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Closed Then
            conn.ConnectionString = "host = localhost; user = root; password = root; database = project;"
            conn.Open()
        End If
        loadListViewCourses(5)

        Dim regTB As String
        RegistrationTextBox1.Text = Student_Info_form.RegistrationNum


        Dim readProgName As New MySqlCommand("SELECT Programme_Name from programme_table", conn)

        Try
            'conn.Open()
            dtr = readProgName.ExecuteReader
            While dtr.Read
                selProgComboBox.Items.Add(dtr.Item("Programme_Name").ToString())
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)

            Application.Exit()

        End Try
        conn.Close()
    End Sub
    'this is the beginning of the loadCourse code
    Public Sub loadListViewCourses(type As Integer)

        Dim dbQuery As String
        If type = 5 Then
            dbQuery = "SELECT * FROM all_course_table where type = 5"
        ElseIf type = 0 Then
            dbQuery = "SELECT * FROM all_course_table where type = 5 or type = 0"
        ElseIf type = 1 Then
            dbQuery = "SELECT * FROM all_course_table where type = 5 or type = 1"
        ElseIf type = 2 Then
            dbQuery = "SELECT * FROM all_course_table where type = 5 or type = 2"
        ElseIf type = 3 Then
            dbQuery = "SELECT * FROM all_course_table where type = 5 or type = 3"
        ElseIf type = 4 Then
            dbQuery = "SELECT * FROM all_course_table where type = 5 or type = 4"

        End If



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
    'this is the end of the loadCourse Code


    Private Sub selProgComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles selProgComboBox.SelectedIndexChanged
        If selProgComboBox.SelectedItem = "INTELLIGENT SYSTEM ENGINEERING" Then
            CourseRegistrationListView.Items.Clear()
            loadListViewCourses(0)


        ElseIf selProgComboBox.SelectedItem = "INFORMATION SYSTEM" Then
            CourseRegistrationListView.Items.Clear()
            loadListViewCourses(1)

        ElseIf selProgComboBox.SelectedItem = "COMPUTER ENGINEERING" Then
            CourseRegistrationListView.Items.Clear()
            loadListViewCourses(2)

        ElseIf selProgComboBox.SelectedItem = "COMPUTER SCIENCE" Then
            CourseRegistrationListView.Items.Clear()
            loadListViewCourses(3)


        ElseIf selProgComboBox.SelectedItem = "SOFTWARE ENGINEERING" Then
            CourseRegistrationListView.Items.Clear()
            loadListViewCourses(4)


        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        If conn.State = ConnectionState.Closed Then
            conn.ConnectionString = "host = localhost; user = root; password = root; database = project;"
            conn.Open()
        End If

        Dim RegistrationNum As String
        RegistrationNum = RegistrationTextBox1.Text
        Course_form.Show()
        For Each Item As ListViewItem In CourseRegistrationListView.Items
            If Item.Checked Then
                Dim index As Integer
                Dim course_code As String
                Dim course_title As String
                Dim course_unit As String
                Dim num As String
                Dim Semester As String
                index = Item.Index
                course_code = Item.SubItems(0).Text
                course_title = Item.SubItems(1).Text
                course_unit = Item.SubItems(2).Text

                Dim InsertQuery As New MySqlCommand("INSERT INTO student_table(registration_no,course_title,course_unit,course_code,semester) VALUES('" + RegistrationNum + "','" + course_title + "','" + course_unit + "','" + course_code + "','" + session + "')", conn)
                InsertQuery.ExecuteNonQuery()
            End If
        Next
    End Sub

    Private Sub RegistrationTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RegistrationTextBox1.TextChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton2.Checked Then
            session = "Harmattan"
        Else
            session = "Rain"
        End If
    End Sub
End Class
