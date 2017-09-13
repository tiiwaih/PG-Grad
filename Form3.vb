Imports MySql.Data.MySqlClient


Public Class Student_Info_form
    Dim conn As New MySqlConnection("host=localhost; user=root;password=root;database=project")
    Dim cmd As New MySqlCommand
    Dim dtr As MySqlDataReader
    Dim TABLE As New DataTable
    Dim Sex As String
    Public selProgg As String
    Public RegistrationNum As String
    Public sName As String
    Public oNames As String
    Public mobNum As String
    Public eMail As String

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Closed Then
            conn.ConnectionString = "host = localhost; user = root; password = root; database = project;"
            conn.Open()
        End If


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        RegistrationNum = RegistrationNumTextBox.Text


        sName = sNameTB.Text


        oNames = oNamesTB.Text


        mobNum = mobNumTB.Text


        eMail = eMailTB.Text


        selProgg = selProgrammeCB.Text

        
        Dim progName As New MySqlCommand("INSERT INTO biodata (Registration_No,surname,Other_names,sex,Phone_no,Email,Programme) VALUES('" + RegistrationNum + "','" + sName + "','" + oNames + "','" + Sex + "','" + mobNum + "','" + eMail + "','" + selProgg + "')", conn)
        progName.ExecuteNonQuery()

        Form1.Show()
    End Sub

    
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles selProgrammeCB.SelectedIndexChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Sex = "male"
        Else
            Sex = "female"
        End If
    End Sub
End Class