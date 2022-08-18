Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles subaruButton.Click
        displayPictureBox1.Image = subaruPictureBox.Image
        carLabel.Text = "subaru"
        horsepowerLabel.Text = "228"
        type.Text = "brz"
        manuallabel.Text = "6 speed"

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles manuallabel.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        displayPictureBox1.Image = viperPictureBox.Image
        carLabel.Text = "dodge"
        horsepowerLabel.Text = "180"
        type.Text = "viper"
        manuallabel.Text = "6 speed"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles civicButton3.Click
        displayPictureBox1.Image = civicPictureBox.Image
        carLabel.Text = "honda"
        horsepowerLabel.Text = "180"
        type.Text = "civic"
        manuallabel.Text = "6 speed"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles skylinebutton.Click
        displayPictureBox1.Image = skylinePictureBox.Image
        carLabel.Text = "Skyline"
        horsepowerLabel.Text = "276"
        type.Text = "r34"
        manuallabel.Text = "6 speed"
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles skylinePictureBox.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles supraPictureBox.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles suprabutton.Click
        displayPictureBox1.Image = supraPictureBox.Image
        carLabel.Text = "supra"
        horsepowerLabel.Text = "321"
        type.Text = "mk4"
        manuallabel.Text = "5 speed"
    End Sub
End Class