Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Guna.UI2.WinForms
Imports MySqlConnector

Public Class _20itemsassess
    Dim connStr As String = "Server=localhost;port=3306; user=root; password=; database=teem"
    Dim conn As New MySqlConnection(connStr)


    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim table1 As String = TCreateAssess.teemgcode.Text + TCreateAssess.assessno.Text
        Try
            conn.Open()

            Dim insertQuery As String = "INSERT INTO `" & table1 & "` (tidnum, assesstype, assessno, teemcode, itemnum, question, choicea, choiceb, choicec, choiced, ans) VALUES (@tidnum, @assesstype, @assessno, @teemcode,@itemnum, @question, @choicea, @choiceb, @choicec, @choiced, @ans)"

            Dim cmd As New MySqlCommand(insertQuery, conn)
            cmd.Parameters.AddWithValue("@tidnum", TSignin.idnum)
            cmd.Parameters.AddWithValue("@assesstype", TCreateAssess.examtype.SelectedItem)
            cmd.Parameters.AddWithValue("@assessno", TCreateAssess.assessno.Text)
            cmd.Parameters.AddWithValue("@teemcode", TCreateAssess.teemgcode.Text)
            cmd.Parameters.AddWithValue("@itemnum", Label1.Text)
            cmd.Parameters.AddWithValue("@question", ques1.Text)
            cmd.Parameters.AddWithValue("@choicea", txt1a.Text)
            cmd.Parameters.AddWithValue("@choiceb", txt1b.Text)
            cmd.Parameters.AddWithValue("@choicec", txt1c.Text)
            cmd.Parameters.AddWithValue("@choiced", txt1d.Text)
            cmd.Parameters.AddWithValue("@ans", ans1.Text)


            cmd.ExecuteNonQuery()

            ques1.ReadOnly = True
            txt1a.ReadOnly = True
            txt1b.ReadOnly = True
            txt1c.ReadOnly = True
            txt1d.ReadOnly = True
            ans1.ReadOnly = True

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim table1 As String = TCreateAssess.teemgcode.Text + TCreateAssess.assessno.Text
        Try
            conn.Open()

            Dim insertQuery As String = "INSERT INTO `" & table1 & "` (tidnum, assessno, teemcode, itemnum, question, choicea, choiceb, choicec, choiced, ans) VALUES (@tidnum,@assessno, @teemcode,@itemnum, @question, @choicea, @choiceb, @choicec, @choiced, @ans)"

            Dim cmd As New MySqlCommand(insertQuery, conn)
            cmd.Parameters.AddWithValue("@tidnum", TSignin.idnum)
            cmd.Parameters.AddWithValue("@assesstype", TCreateAssess.examtype.SelectedItem)
            cmd.Parameters.AddWithValue("@assessno", TCreateAssess.assessno.Text)
            cmd.Parameters.AddWithValue("@teemcode", TCreateAssess.teemgcode.Text)
            cmd.Parameters.AddWithValue("@itemnum", Label2.Text)
            cmd.Parameters.AddWithValue("@question", ques2.Text)
            cmd.Parameters.AddWithValue("@choicea", txt2a.Text)
            cmd.Parameters.AddWithValue("@choiceb", txt2b.Text)
            cmd.Parameters.AddWithValue("@choicec", txt2c.Text)
            cmd.Parameters.AddWithValue("@choiced", txt2d.Text)
            cmd.Parameters.AddWithValue("@ans", ans2.Text)


            cmd.ExecuteNonQuery()

            ques1.ReadOnly = True
            txt1a.ReadOnly = True
            txt1b.ReadOnly = True
            txt1c.ReadOnly = True
            txt1d.ReadOnly = True
            ans1.ReadOnly = True

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim table1 As String = TCreateAssess.teemgcode.Text + TCreateAssess.assessno.Text
        Try
            conn.Open()

            Dim insertQuery As String = "INSERT INTO `" & table1 & "` (tidnum, assessno, teemcode, itemnum, question, choicea, choiceb, choicec, choiced, ans) VALUES (@tidnum,@assessno, @teemcode,@itemnum, @question, @choicea, @choiceb, @choicec, @choiced, @ans)"

            Dim cmd As New MySqlCommand(insertQuery, conn)
            cmd.Parameters.AddWithValue("@tidnum", TSignin.idnum)
            cmd.Parameters.AddWithValue("@assesstype", TCreateAssess.examtype.SelectedItem)
            cmd.Parameters.AddWithValue("@assessno", TCreateAssess.assessno.Text)
            cmd.Parameters.AddWithValue("@teemcode", TCreateAssess.teemgcode.Text)
            cmd.Parameters.AddWithValue("@itemnum", Label3.Text)
            cmd.Parameters.AddWithValue("@question", ques3.Text)
            cmd.Parameters.AddWithValue("@choicea", txt3a.Text)
            cmd.Parameters.AddWithValue("@choiceb", txt3b.Text)
            cmd.Parameters.AddWithValue("@choicec", txt3c.Text)
            cmd.Parameters.AddWithValue("@choiced", txt3d.Text)
            cmd.Parameters.AddWithValue("@ans", ans3.Text)


            cmd.ExecuteNonQuery()

            MessageBox.Show("Data inserted successfully!")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Dim table1 As String = TCreateAssess.teemgcode.Text + TCreateAssess.assessno.Text
        Try
            conn.Open()

            Dim insertQuery As String = "INSERT INTO `" & table1 & "` (tidnum, assessno, teemcode, itemnum, question, choicea, choiceb, choicec, choiced, ans) VALUES (@tidnum,@assessno, @teemcode,@itemnum, @question, @choicea, @choiceb, @choicec, @choiced, @ans)"

            Dim cmd As New MySqlCommand(insertQuery, conn)
            cmd.Parameters.AddWithValue("@tidnum", TSignin.idnum)
            cmd.Parameters.AddWithValue("@assesstype", TCreateAssess.examtype.SelectedItem)
            cmd.Parameters.AddWithValue("@assessno", TCreateAssess.assessno.Text)
            cmd.Parameters.AddWithValue("@teemcode", TCreateAssess.teemgcode.Text)
            cmd.Parameters.AddWithValue("@itemnum", Label4.Text)
            cmd.Parameters.AddWithValue("@question", ques4.Text)
            cmd.Parameters.AddWithValue("@choicea", txt4a.Text)
            cmd.Parameters.AddWithValue("@choiceb", txt4b.Text)
            cmd.Parameters.AddWithValue("@choicec", txt4c.Text)
            cmd.Parameters.AddWithValue("@choiced", txt4d.Text)
            cmd.Parameters.AddWithValue("@ans", ans4.Text)


            cmd.ExecuteNonQuery()

            MessageBox.Show("Data inserted successfully!")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Dim table1 As String = TCreateAssess.teemgcode.Text + TCreateAssess.assessno.Text
        Try
            conn.Open()

            Dim insertQuery As String = "INSERT INTO `" & table1 & "` (tidnum, assessno, teemcode, itemnum, question, choicea, choiceb, choicec, choiced, ans) VALUES (@tidnum,@assessno, @teemcode,@itemnum, @question, @choicea, @choiceb, @choicec, @choiced, @ans)"

            Dim cmd As New MySqlCommand(insertQuery, conn)
            cmd.Parameters.AddWithValue("@tidnum", TSignin.idnum)
            cmd.Parameters.AddWithValue("@assesstype", TCreateAssess.examtype.SelectedItem)
            cmd.Parameters.AddWithValue("@assessno", TCreateAssess.assessno.Text)
            cmd.Parameters.AddWithValue("@teemcode", TCreateAssess.teemgcode.Text)
            cmd.Parameters.AddWithValue("@itemnum", Label5.Text)
            cmd.Parameters.AddWithValue("@question", ques5.Text)
            cmd.Parameters.AddWithValue("@choicea", txt5a.Text)
            cmd.Parameters.AddWithValue("@choiceb", txt5b.Text)
            cmd.Parameters.AddWithValue("@choicec", txt5c.Text)
            cmd.Parameters.AddWithValue("@choiced", txt5d.Text)
            cmd.Parameters.AddWithValue("@ans", ans5.Text)


            cmd.ExecuteNonQuery()

            MessageBox.Show("Data inserted successfully!")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Dim table1 As String = TCreateAssess.teemgcode.Text + TCreateAssess.assessno.Text
        Try
            conn.Open()

            Dim insertQuery As String = "INSERT INTO `" & table1 & "` (tidnum, assessno, teemcode, itemnum, question, choicea, choiceb, choicec, choiced, ans) VALUES (@tidnum,@assessno, @teemcode,@itemnum, @question, @choicea, @choiceb, @choicec, @choiced, @ans)"

            Dim cmd As New MySqlCommand(insertQuery, conn)
            cmd.Parameters.AddWithValue("@tidnum", TSignin.idnum)
            cmd.Parameters.AddWithValue("@assesstype", TCreateAssess.examtype.SelectedItem)
            cmd.Parameters.AddWithValue("@assessno", TCreateAssess.assessno.Text)
            cmd.Parameters.AddWithValue("@teemcode", TCreateAssess.teemgcode.Text)
            cmd.Parameters.AddWithValue("@itemnum", Label6.Text)
            cmd.Parameters.AddWithValue("@question", ques6.Text)
            cmd.Parameters.AddWithValue("@choicea", txt6a.Text)
            cmd.Parameters.AddWithValue("@choiceb", txt6b.Text)
            cmd.Parameters.AddWithValue("@choicec", txt6c.Text)
            cmd.Parameters.AddWithValue("@choiced", txt6d.Text)
            cmd.Parameters.AddWithValue("@ans", ans6.Text)


            cmd.ExecuteNonQuery()

            MessageBox.Show("Data inserted successfully!")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        Dim table1 As String = TCreateAssess.teemgcode.Text + TCreateAssess.assessno.Text
        Try
            conn.Open()

            Dim insertQuery As String = "INSERT INTO `" & table1 & "` (tidnum, assessno, teemcode, itemnum, question, choicea, choiceb, choicec, choiced, ans) VALUES (@tidnum,@assessno, @teemcode,@itemnum, @question, @choicea, @choiceb, @choicec, @choiced, @ans)"

            Dim cmd As New MySqlCommand(insertQuery, conn)
            cmd.Parameters.AddWithValue("@tidnum", TSignin.idnum)
            cmd.Parameters.AddWithValue("@assesstype", TCreateAssess.examtype.SelectedItem)
            cmd.Parameters.AddWithValue("@assessno", TCreateAssess.assessno.Text)
            cmd.Parameters.AddWithValue("@teemcode", TCreateAssess.teemgcode.Text)
            cmd.Parameters.AddWithValue("@itemnum", Label7.Text)
            cmd.Parameters.AddWithValue("@question", ques7.Text)
            cmd.Parameters.AddWithValue("@choicea", txt7a.Text)
            cmd.Parameters.AddWithValue("@choiceb", txt7b.Text)
            cmd.Parameters.AddWithValue("@choicec", txt7c.Text)
            cmd.Parameters.AddWithValue("@choiced", txt7d.Text)
            cmd.Parameters.AddWithValue("@ans", ans7.Text)


            cmd.ExecuteNonQuery()

            MessageBox.Show("Data inserted successfully!")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        Dim table1 As String = TCreateAssess.teemgcode.Text + TCreateAssess.assessno.Text
        Try
            conn.Open()

            Dim insertQuery As String = "INSERT INTO `" & table1 & "` (tidnum, assessno, teemcode, itemnum, question, choicea, choiceb, choicec, choiced, ans) VALUES (@tidnum,@assessno, @teemcode,@itemnum, @question, @choicea, @choiceb, @choicec, @choiced, @ans)"

            Dim cmd As New MySqlCommand(insertQuery, conn)
            cmd.Parameters.AddWithValue("@tidnum", TSignin.idnum)
            cmd.Parameters.AddWithValue("@assesstype", TCreateAssess.examtype.SelectedItem)
            cmd.Parameters.AddWithValue("@assessno", TCreateAssess.assessno.Text)
            cmd.Parameters.AddWithValue("@teemcode", TCreateAssess.teemgcode.Text)
            cmd.Parameters.AddWithValue("@itemnum", Label8.Text)
            cmd.Parameters.AddWithValue("@question", ques8.Text)
            cmd.Parameters.AddWithValue("@choicea", txt8a.Text)
            cmd.Parameters.AddWithValue("@choiceb", txt8b.Text)
            cmd.Parameters.AddWithValue("@choicec", txt8c.Text)
            cmd.Parameters.AddWithValue("@choiced", txt8d.Text)
            cmd.Parameters.AddWithValue("@ans", ans8.Text)


            cmd.ExecuteNonQuery()

            MessageBox.Show("Data inserted successfully!")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Guna2Button10_Click(sender As Object, e As EventArgs) Handles Guna2Button10.Click
        Dim table1 As String = TCreateAssess.teemgcode.Text + TCreateAssess.assessno.Text
        Try
            conn.Open()

            Dim insertQuery As String = "INSERT INTO `" & table1 & "` (tidnum, assessno, teemcode, itemnum, question, choicea, choiceb, choicec, choiced, ans) VALUES (@tidnum,@assessno, @teemcode,@itemnum, @question, @choicea, @choiceb, @choicec, @choiced, @ans)"

            Dim cmd As New MySqlCommand(insertQuery, conn)
            cmd.Parameters.AddWithValue("@tidnum", TSignin.idnum)
            cmd.Parameters.AddWithValue("@assesstype", TCreateAssess.examtype.SelectedItem)
            cmd.Parameters.AddWithValue("@assessno", TCreateAssess.assessno.Text)
            cmd.Parameters.AddWithValue("@teemcode", TCreateAssess.teemgcode.Text)
            cmd.Parameters.AddWithValue("@itemnum", Label9.Text)
            cmd.Parameters.AddWithValue("@question", ques9.Text)
            cmd.Parameters.AddWithValue("@choicea", txt9a.Text)
            cmd.Parameters.AddWithValue("@choiceb", txt9b.Text)
            cmd.Parameters.AddWithValue("@choicec", txt9c.Text)
            cmd.Parameters.AddWithValue("@choiced", txt9d.Text)
            cmd.Parameters.AddWithValue("@ans", ans9.Text)


            cmd.ExecuteNonQuery()

            MessageBox.Show("Data inserted successfully!")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub _20itemsassess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2Button2.Visible = False
        Guna2Button3.Visible = False
        Guna2Button4.Visible = False
        Guna2Button5.Visible = False
        Guna2Button6.Visible = False
        Guna2Button7.Visible = False
        Guna2Button8.Visible = False
        Guna2Button9.Visible = False
        Guna2Button10.Visible = False
        Guna2Button11.Visible = False
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            conn.Open()

            Dim insertQuery As String = "INSERT INTO examss(assessno, coursename, coursecode, coursegcode, assesstype, item1, ques1, choice1a, choice1b, choice1c, 
                                                            choice1d, ans1, item2, ques2, choice2a, choice2b, choice2c, choice2d, ans2, item3, ques3, 
                                                            choice3a, choice3b, choice3c, choice3d, ans3, item4, ques4, choice4a, choice4b, choice4c, 
                                                            choice4d, ans4, item5, ques5, choice5a, choice5b, choice5c, choice5d, ans5, item6, ques6, 
                                                            choice6a, choice6b, choice6c, choice6d, ans6, item7, ques7, choice7a, choice7b, choice7c, 
                                                            choice7d, ans7, item8, ques8, choice8a, choice8b, choice8c, choice8d, ans8, item9, ques9, 
                                                            choice9a, choice9b, choice9c, choice9d, ans9, item10, ques10, choice10a, choice10b, choice10c, 
                                                            choice10d, ans10) VALUES (@assessno, @coursename, @coursecode, @coursegcode, @assesstype, @item1, @ques1, 
                                                            @choice1a, @choice1b, @choice1c, @choice1d, @ans1, @item2, @ques2, @choice2a, @choice2b, @choice2c, 
                                                            @choice2d, @ans2, @item3, @ques3, @choice3a, @choice3b, @choice3c, @choice3d, @ans3, @item4, @ques4, 
                                                            @choice4a, @choice4b, @choice4c, @choice4d, @ans4, @item5, @ques5, @choice5a, @choice5b,
                                                            @choice5c, @choice5d, @ans5, @item6, @ques6, @choice6a, @choice6b, @choice6c, @choice6d, 
                                                            @ans6, @item7, @ques7, @choice7a, @choice7b, @choice7c, @choice7d, @ans7, @item8, @ques8, 
                                                            @choice8a, @choice8b, @choice8c, @choice8d, @ans8, @item9, @ques9, @choice9a, @choice9b, 
                                                            @choice9c, @choice9d, @ans9, @item10, @ques10, @choice10a, @choice10b, @choice10c, @choice10d, @ans10)"

            Dim cmd As New MySqlCommand(insertQuery, conn)
            cmd.Parameters.AddWithValue("@assessno", TCreateAssess.assessno.Text)
            cmd.Parameters.AddWithValue("@coursename", TCreateAssess.cnametxt.Text)
            cmd.Parameters.AddWithValue("@coursecode", TCreateAssess.ccodetxt.Text)
            cmd.Parameters.AddWithValue("@coursegcode", TCreateAssess.teemgcode.Text)
            cmd.Parameters.AddWithValue("@assesstype", TCreateAssess.examtype.SelectedItem)
            cmd.Parameters.AddWithValue("@item1", Label1.Text)
            cmd.Parameters.AddWithValue("@ques1", ques1.Text)
            cmd.Parameters.AddWithValue("@choice1a", txt1a.Text)
            cmd.Parameters.AddWithValue("@choice1b", txt1b.Text)
            cmd.Parameters.AddWithValue("@choice1c", txt1c.Text)
            cmd.Parameters.AddWithValue("@choice1d", txt1d.Text)
            cmd.Parameters.AddWithValue("@ans1", ans1.Text)
            cmd.Parameters.AddWithValue("@item2", Label2.Text)
            cmd.Parameters.AddWithValue("@ques2", ques2.Text)
            cmd.Parameters.AddWithValue("@choice2a", txt2a.Text)
            cmd.Parameters.AddWithValue("@choice2b", txt2b.Text)
            cmd.Parameters.AddWithValue("@choice2c", txt2c.Text)
            cmd.Parameters.AddWithValue("@choice2d", txt2d.Text)
            cmd.Parameters.AddWithValue("@ans2", ans2.Text)
            cmd.Parameters.AddWithValue("@item3", Label3.Text)
            cmd.Parameters.AddWithValue("@ques3", ques3.Text)
            cmd.Parameters.AddWithValue("@choice3a", txt3a.Text)
            cmd.Parameters.AddWithValue("@choice3b", txt3b.Text)
            cmd.Parameters.AddWithValue("@choice3c", txt3c.Text)
            cmd.Parameters.AddWithValue("@choice3d", txt3d.Text)
            cmd.Parameters.AddWithValue("@ans3", ans3.Text)
            cmd.Parameters.AddWithValue("@item4", Label4.Text)
            cmd.Parameters.AddWithValue("@ques4", ques4.Text)
            cmd.Parameters.AddWithValue("@choice4a", txt4a.Text)
            cmd.Parameters.AddWithValue("@choice4b", txt4b.Text)
            cmd.Parameters.AddWithValue("@choice4c", txt4c.Text)
            cmd.Parameters.AddWithValue("@choice4d", txt4d.Text)
            cmd.Parameters.AddWithValue("@ans4", ans4.Text)
            cmd.Parameters.AddWithValue("@item5", Label5.Text)
            cmd.Parameters.AddWithValue("@ques5", ques5.Text)
            cmd.Parameters.AddWithValue("@choice5a", txt5a.Text)
            cmd.Parameters.AddWithValue("@choice5b", txt5b.Text)
            cmd.Parameters.AddWithValue("@choice5c", txt5c.Text)
            cmd.Parameters.AddWithValue("@choice5d", txt5d.Text)
            cmd.Parameters.AddWithValue("@ans5", ans5.Text)
            cmd.Parameters.AddWithValue("@item6", Label6.Text)
            cmd.Parameters.AddWithValue("@ques6", ques6.Text)
            cmd.Parameters.AddWithValue("@choice6a", txt6a.Text)
            cmd.Parameters.AddWithValue("@choice6b", txt6b.Text)
            cmd.Parameters.AddWithValue("@choice6c", txt6c.Text)
            cmd.Parameters.AddWithValue("@choice6d", txt6d.Text)
            cmd.Parameters.AddWithValue("@ans6", ans6.Text)
            cmd.Parameters.AddWithValue("@item7", Label7.Text)
            cmd.Parameters.AddWithValue("@ques7", ques7.Text)
            cmd.Parameters.AddWithValue("@choice7a", txt7a.Text)
            cmd.Parameters.AddWithValue("@choice7b", txt7b.Text)
            cmd.Parameters.AddWithValue("@choice7c", txt7c.Text)
            cmd.Parameters.AddWithValue("@choice7d", txt7d.Text)
            cmd.Parameters.AddWithValue("@ans7", ans7.Text)
            cmd.Parameters.AddWithValue("@item8", Label8.Text)
            cmd.Parameters.AddWithValue("@ques8", ques8.Text)
            cmd.Parameters.AddWithValue("@choice8a", txt8a.Text)
            cmd.Parameters.AddWithValue("@choice8b", txt8b.Text)
            cmd.Parameters.AddWithValue("@choice8c", txt8c.Text)
            cmd.Parameters.AddWithValue("@choice8d", txt8d.Text)
            cmd.Parameters.AddWithValue("@ans8", ans8.Text)
            cmd.Parameters.AddWithValue("@item9", Label9.Text)
            cmd.Parameters.AddWithValue("@ques9", ques9.Text)
            cmd.Parameters.AddWithValue("@choice9a", txt9a.Text)
            cmd.Parameters.AddWithValue("@choice9b", txt9b.Text)
            cmd.Parameters.AddWithValue("@choice9c", txt9c.Text)
            cmd.Parameters.AddWithValue("@choice9d", txt9d.Text)
            cmd.Parameters.AddWithValue("@ans9", ans9.Text)
            cmd.Parameters.AddWithValue("@item10", Label10.Text)
            cmd.Parameters.AddWithValue("@ques10", ques10.Text)
            cmd.Parameters.AddWithValue("@choice10a", txt10a.Text)
            cmd.Parameters.AddWithValue("@choice10b", txt10b.Text)
            cmd.Parameters.AddWithValue("@choice10c", txt10c.Text)
            cmd.Parameters.AddWithValue("@choice10d", txt10d.Text)
            cmd.Parameters.AddWithValue("@ans10", ans10.Text)


            cmd.ExecuteNonQuery()

            MessageBox.Show("Data inserted successfully!")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Guna2Button11_Click(sender As Object, e As EventArgs) Handles Guna2Button11.Click
        Dim table1 As String = TCreateAssess.teemgcode.Text + TCreateAssess.assessno.Text
        Try
            conn.Open()

            Dim insertQuery As String = "INSERT INTO `" & table1 & "` (tidnum, assessno, teemcode, itemnum, question, choicea, choiceb, choicec, choiced, ans) VALUES (@tidnum,@assessno, @teemcode,@itemnum, @question, @choicea, @choiceb, @choicec, @choiced, @ans)"

            Dim cmd As New MySqlCommand(insertQuery, conn)
            cmd.Parameters.AddWithValue("@tidnum", TSignin.idnum)
            cmd.Parameters.AddWithValue("@assesstype", TCreateAssess.examtype.SelectedItem)
            cmd.Parameters.AddWithValue("@assessno", TCreateAssess.assessno.Text)
            cmd.Parameters.AddWithValue("@teemcode", TCreateAssess.teemgcode.Text)
            cmd.Parameters.AddWithValue("@itemnum", Label10.Text)
            cmd.Parameters.AddWithValue("@question", ques10.Text)
            cmd.Parameters.AddWithValue("@choicea", txt10a.Text)
            cmd.Parameters.AddWithValue("@choiceb", txt10b.Text)
            cmd.Parameters.AddWithValue("@choicec", txt10c.Text)
            cmd.Parameters.AddWithValue("@choiced", txt10d.Text)
            cmd.Parameters.AddWithValue("@ans", ans10.Text)


            cmd.ExecuteNonQuery()

            MessageBox.Show("Data inserted successfully!")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Guna2Button12_Click(sender As Object, e As EventArgs)

    End Sub
End Class