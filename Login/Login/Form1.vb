Imports System.ComponentModel

Public Class Form1
    Private Sub btnSesion_Click(sender As Object, e As EventArgs) Handles btnSesion.Click
        Try
            If Me.ValidateChildren And txtAdmin.Text <> String.Empty And txtpass.Text <> String.Empty Then
                If txtAdmin.Text = "Administrador" And txtpass.Text = "SinHacer2020" Then
                    Ingreso_pruebas.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Revise los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Revise los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtAdmin_MouseHover(sender As Object, e As EventArgs) Handles txtAdmin.MouseHover
        ToolTip1.SetToolTip(txtAdmin, "Ingrese de forma correcta el usuario")
        ToolTip1.ToolTipTitle = "Usuario"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtpass_MouseHover(sender As Object, e As EventArgs) Handles txtpass.MouseHover
        ToolTip1.SetToolTip(txtpass, "Ingrese la contraseña correcta")
        ToolTip1.ToolTipTitle = "Contraseña"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub txtAdmin_Validating(sender As Object, e As CancelEventArgs) Handles txtAdmin.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub
End Class
