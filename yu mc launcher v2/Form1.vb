Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ListBox1.SelectedItem = "config1" Then
            TextBox1.Text = My.Settings.s1_ver
        End If
        If ListBox1.SelectedItem = "config2" Then
            TextBox1.Text = My.Settings.s2_ver
        End If
        If ListBox1.SelectedItem = "config3" Then
            TextBox1.Text = My.Settings.s3_ver
        End If
        TextBox4.Text = My.Settings.lowmem
        TextBox5.Text = My.Settings.highmem
        TextBox3.Text = My.Settings.username
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MinecraftProcessInfo As ProcessStartInfo = New ProcessStartInfo
        MinecraftProcessInfo.FileName = "JBOOTAPI.BAT"
        MinecraftProcessInfo.Arguments = TextBox1.Text + " " + TextBox4.Text + " " + TextBox5.Text + " " + TextBox2.Text + " " + TextBox3.Text
        If CheckBox1.Checked = True Then
            MinecraftProcessInfo.UseShellExecute = True
        End If
        If CheckBox1.Checked = False Then
            MinecraftProcessInfo.UseShellExecute = False
        End If
        Dim MinecraftProcess As Process = Process.Start(MinecraftProcessInfo)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedItem = "config1" Then
            My.Settings.s1_ver = TextBox1.Text
        End If
        If ListBox1.SelectedItem = "config2" Then
            My.Settings.s2_ver = TextBox1.Text
        End If
        If ListBox1.SelectedItem = "config3" Then
            My.Settings.s3_ver = TextBox1.Text
        End If
        My.Settings.lowmem = TextBox4.Text
        My.Settings.highmem = TextBox5.Text
        My.Settings.username = TextBox3.Text
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem = "config1" Then
            TextBox1.Text = My.Settings.s1_ver
        End If
        If ListBox1.SelectedItem = "config2" Then
            TextBox1.Text = My.Settings.s2_ver
        End If
        If ListBox1.SelectedItem = "config3" Then
            TextBox1.Text = My.Settings.s3_ver
        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs)

    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub 終了ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 終了ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub リソースダウンローダーResourceDownloaderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles リソースダウンローダーResourceDownloaderToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub

    Private Sub 使い方HowToUseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 使い方HowToUseToolStripMenuItem.Click
        Form3.ShowDialog()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub YuMCLauncherについてAboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YuMCLauncherについてAboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub
End Class
