Imports System.Data.OleDb

Public Class Form4
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Public Property IsEditMode As Boolean = False
    Dim requete As String

    Private Sub connexion()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AssoManager.accdb")
        con.Open()
    End Sub

    Private Sub cmdsql()
        cmd = New OleDbCommand(requete, con)
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Initialize TextBox1 if it doesn't exist
        If TextBox1 Is Nothing Then
            TextBox1 = New TextBox()
            TextBox1.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Regular)
            TextBox1.Size = New Size(201, 30)
            TextBox1.Location = New Point(188, 19)
            Me.Controls.Add(TextBox1)
        End If
        
        ' Check edit mode based on ancienidtypeassociation or IsEditMode property
        If IsEditMode OrElse (Not String.IsNullOrEmpty(ancienidtypeassociation.Text) AndAlso ancienidtypeassociation.Text <> "0") Then
            enregistrer2.Text = "Modifier"
            ancienidtypeassociation.Visible = True
            IsEditMode = True
        Else
            enregistrer2.Text = "Ajouter"
            ancienidtypeassociation.Visible = False
            TextBox1.Enabled = False
            IsEditMode = False
        End If

        ' Make sure TextBox4 is configured correctly
        TextBox4.Multiline = True
        TextBox4.ScrollBars = ScrollBars.Vertical
    End Sub

    Private Sub enregistrer2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enregistrer2.Click
        If TextBox0.Text.Trim() = "" Then
            MsgBox("Veuillez entrer un nom pour le type d'association", vbExclamation, "Données manquantes")
            TextBox0.Focus()
            Return
        End If

        connexion()
        
        If Not IsEditMode OrElse enregistrer2.Text = "Ajouter" Then
            ' For adding new record
            requete = "INSERT INTO typeassociation (type, description) VALUES ('" & TextBox0.Text & "', '" & TextBox4.Text & "')"
        Else
            ' For updating existing record - make sure we have a valid ID
            ' Update query using the ID from ancienidtypeassociation
            requete = "UPDATE typeassociation SET type = '" & TextBox0.Text & "', description = '" & TextBox4.Text & "' WHERE idtypeassociation = " & ancienidtypeassociation.Text
        End If
        
        ' Execute the query
        cmdsql()
        cmd.ExecuteNonQuery()
        
        con.Close()

        ' Refresh data in parent form
        Dim f3 As Form3 = CType(Application.OpenForms("Form3"), Form3)
        If f3 IsNot Nothing Then
            f3.afficher_typeassociation()
        End If

        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
    End Sub
End Class