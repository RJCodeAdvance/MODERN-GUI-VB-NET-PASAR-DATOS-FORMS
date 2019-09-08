Public Class FormAgenda
    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim frm As New FormPacientes
        frm.lblHelp.Visible = True
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub
End Class