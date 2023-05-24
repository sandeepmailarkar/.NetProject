Public Class WelCome
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Name.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
     {
        String First Name = tbFirstName.Text;
        String Last Name = tbLastName.Text;
        lbWelCome.Text = "Hello" + Firstname + " " + LastName;
     }
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        {
                tbFirstName.Text = "";
              tbLastName.Text = "";
             lbWelCome.Text = "";
        }
    End Sub
End Class
