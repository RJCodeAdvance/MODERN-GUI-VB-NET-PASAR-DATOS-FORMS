Public Class FormPacientes
    Private Sub FormPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InsertarFilas()
    End Sub
    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub InsertarFilas()
        DataGridView1.Rows.Insert(0, "1", "Rafael", "Fernandez", "AV. Melgar", "56465")
        DataGridView1.Rows.Insert(1, "2", "Rafael", "Fernandez", "AV. Melgar", "56465")
        DataGridView1.Rows.Insert(2, "3", "Rafael", "Fernandez", "AV. Melgar", "56465")
        DataGridView1.Rows.Insert(3, "4", "Rafael", "Fernandez", "AV. Melgar", "56465")
        DataGridView1.Rows.Insert(4, "5", "Rafael", "Fernandez", "AV. Melgar", "56465")
        DataGridView1.Rows.Insert(5, "6", "Rafael", "Fernandez", "AV. Melgar", "56465")
        DataGridView1.Rows.Insert(6, "7", "Rafael", "Fernandez", "AV. Melgar", "56465")
        DataGridView1.Rows.Insert(7, "8", "Rafael", "Fernandez", "AV. Melgar", "56465")
        DataGridView1.Rows.Insert(8, "9", "Rafael", "Fernandez", "AV. Melgar", "56465")
        DataGridView1.Rows.Insert(9, "10", "Rafael", "Fernandez", "AV. Melgar", "56465")
        DataGridView1.Rows.Insert(10, "11", "Rafael", "Fernandez", "AV. Melgar", "56465")
        DataGridView1.Rows.Insert(11, "12", "Rafael", "Fernandez", "AV. Melgar", "56465")
        DataGridView1.Rows.Insert(12, "13", "Rafael", "Fernandez", "AV. Melgar", "56465")
        DataGridView1.Rows.Insert(13, "14", "Rafael", "Fernandez", "AV. Melgar", "56465")
        DataGridView1.Rows.Insert(14, "15", "Rafael", "Fernandez", "AV. Melgar", "56465")
        DataGridView1.Rows.Insert(15, "16", "Rafael", "Fernandez", "AV. Melgar", "56465")
        DataGridView1.Rows.Insert(16, "17", "Rafael", "Fernandez", "AV. Melgar", "56465")
        DataGridView1.Rows.Insert(17, "18", "Rafael", "Fernandez", "AV. Melgar", "56465")
        DataGridView1.Rows.Insert(18, "19", "Rafael", "Fernandez", "AV. Melgar", "56465")
        DataGridView1.Rows.Insert(19, "20", "Rafael", "Fernandez", "AV. Melgar", "56465")
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If (DataGridView1.SelectedRows.Count > 0) Then
            Dim frm As New FormMantPacientes
            frm.txtid.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
            frm.txtnombre.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
            frm.txtapellido.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
            frm.txtdireccion.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
            frm.txttelefono.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()

            frm.ShowDialog()
        Else
            MessageBox.Show("Por favor seleccione una fila...")
        End If

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim frm As FormAgenda = CType(Owner, FormAgenda)
        frm.txtid.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        frm.txtnombre.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString() + ", " + DataGridView1.CurrentRow.Cells(2).Value.ToString()
        Me.Close()
    End Sub
End Class