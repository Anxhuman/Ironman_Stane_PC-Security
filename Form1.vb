Imports System.Runtime.InteropServices
Imports System.Reflection
Imports Microsoft.VisualBasic

Public Class Form1

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Alt + Keys.F4 Then
            MessageBox.Show("Unauthorized Access Denied!!", "Security Warnning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Handled = True
        End If
        If e.KeyData = Keys.LWin Then
            MsgBox("Incorrect key pressed", MsgBoxStyle.Exclamation)
            e.Handled = True
        End If

        If e.KeyData = Keys.A Or Keys.B Or Keys.C Or Keys.D Or Keys.E Or Keys.F Or Keys.G Or Keys.H Or Keys.I Or Keys.J Or Keys.K Or Keys.L Or Keys.M Or Keys.N Or Keys.O Or Keys.P Or Keys.Q Or Keys.R Or Keys.S Or Keys.T Or Keys.U Or Keys.V Or Keys.W Or Keys.X Or Keys.Y Or Keys.Z Then
            MessageBox.Show("Unauthorized Access Denied!!", "Security Warnning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Handled = True
        End If

        If e.KeyData = Keys.Control + Keys.Alt + Keys.Delete Then
            MessageBox.Show("Unauthorized Access Denied!!", "Security Warnning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Handled = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TopMost = True
        For Each selProcess As Process In Process.GetProcesses
            If selProcess.ProcessName = "taskmgr" Then
                selProcess.Kill()
                Exit For
            End If
        Next
        For Each selProcess As Process In Process.GetProcesses
            If selProcess.ProcessName = "explorer" Then
                'selProcess.Kill()         'Enable this to kill the Explorer
                'Me.ShowInTaskbar = False  'Enable this to hide the icon on Explorer

                Exit For
            End If
        Next
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyData = Keys.Alt + Keys.Tab Then
            MessageBox.Show("Unauthorized Access Denied!!", "Security Warnning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Handled = True
        End If
        If e.KeyData = Keys.Control + Keys.Alt + Keys.Delete Then
            MessageBox.Show("Unauthorized Access Denied!!", "Security Warnning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Handled = True
        End If

        If e.KeyData = Keys.Alt + Keys.F4 Then
            MessageBox.Show("Unauthorized Access Denied!!", "Security Warnning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Handled = True
        End If
            If e.KeyData = Keys.Enter Then
                If TextBox1.Text = 1234567 Then
                    'Timer1.Stop()
                    'Close()
                    Form2.Show()
                    Process.Start("explorer.exe")
                Close()

            ElseIf TextBox1.Text = Asc(e.KeyData) < 48 Or Asc(e.KeyData) > 57 Then
                e.Handled = True
                MessageBox.Show("Enter Alphabet Only")
            Else
                MsgBox("Password incorrect!", vbCritical)
                End If
            End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
