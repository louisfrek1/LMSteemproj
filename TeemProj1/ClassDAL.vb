
Imports System.Data.SqlClient
Imports System.IO
Imports MySqlConnector

Public Class ClassDAL

    Dim resourceuser As ResourceUser
    Public courcoderes As String
    Public courgoderes As String

    Public Function AddItemsToTable(id As Integer, lastname As String, coursename As String, ccode As Integer, coursetitle As String, cgcode As String, day As String,
                                    hours As String, time As String, term As String, room As String, program As String, image As Image) As Boolean
        Dim con As New Connection()
        If ConnectionState.Closed = con.connect.State Then
            con.connect.Open()
        End If

        Dim query As String = "INSERT INTO teach_addcourse1(`id`, `lastname`, `coursename`, `coursecode`, `coursetitle`, `coursegcode`, `day`, `hours`, `time`, `term`, `room`, `program`, `image`)VALUES(@id,@lastname,@coursename,@ccode,@coursetitle,@cgcode,@day,@hours,@time,@term,@room,@program,@image)"
        Try
            Using cmd As New MySqlCommand(query, con.connect)
                cmd.Parameters.AddWithValue("id", id.ToString().Trim())
                cmd.Parameters.AddWithValue("lastname", lastname.ToString().Trim())
                cmd.Parameters.AddWithValue("coursename", coursename.Trim())
                cmd.Parameters.AddWithValue("ccode", ccode.ToString().Trim()) ' Assuming "ccode" is the correct parameter name
                cmd.Parameters.AddWithValue("coursetitle", coursetitle.Trim())
                cmd.Parameters.AddWithValue("cgcode", cgcode.Trim())
                cmd.Parameters.AddWithValue("day", day.Trim())
                cmd.Parameters.AddWithValue("hours", hours.Trim())
                cmd.Parameters.AddWithValue("time", time.Trim())
                cmd.Parameters.AddWithValue("term", term.Trim())
                cmd.Parameters.AddWithValue("room", room.Trim())
                cmd.Parameters.AddWithValue("program", program.Trim())

                Dim ms As New MemoryStream
                image.Save(ms, image.RawFormat)
                cmd.Parameters.AddWithValue("image", ms.ToArray())

                cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            Throw
        End Try
    End Function



    Public Function ReadItemsTable() As DataTable
        Try
            Dim con As New Connection()
            If ConnectionState.Closed = con.connect.State Then
                con.connect.Open()
            End If

            Dim query As String = "SELECT * FROM teach_addcourse1 WHERE id = @id"
            Dim cmd As New MySqlCommand(query, con.connect)
            cmd.Parameters.AddWithValue("@id", TCourses.Label1.Text)

            Using sda As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                sda.Fill(dt)
                Return dt
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ReadItemsTable2() As DataTable
        Try
            Dim con As New Connection()
            If ConnectionState.Closed = con.connect.State Then
                con.connect.Open()
            End If

            Dim query As String = "SELECT * FROM tannouncement WHERE coursegcode = @coursegcode"
            Dim cmd As New MySqlCommand(query, con.connect)
            cmd.Parameters.AddWithValue("@coursegcode", TCourseFeed.coursegcode.Text)

            Using sda As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                sda.Fill(dt)
                Return dt
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function AddItemsToTable2(idnum As Integer, firstname As String, lastname As String, datepost As String, coursename As String,
                                     coursegcode As String, content As String) As Boolean
        Dim con As New Connection()
        If ConnectionState.Closed = con.connect.State Then
            con.connect.Open()
        End If

        Dim query As String = "INSERT INTO tannouncement(`idnum`, `firstname`, `lastname`, `date`, `coursename`, `coursegcode`, `content`)VALUES(@idnum,@firstname,@lastname,@datepost,@coursename,@coursegcode,@content)"
        Try
            Using cmd As New MySqlCommand(query, con.connect)
                cmd.Parameters.AddWithValue("idnum", idnum.ToString().Trim())
                cmd.Parameters.AddWithValue("firstname", firstname.ToString().Trim())
                cmd.Parameters.AddWithValue("lastname", lastname.ToString().Trim())
                cmd.Parameters.AddWithValue("date", datepost.Trim())
                cmd.Parameters.AddWithValue("coursename", coursename.ToString().Trim()) ' Assuming "ccode" is the correct parameter name
                cmd.Parameters.AddWithValue("coursegcode", coursegcode.Trim())
                cmd.Parameters.AddWithValue("content", content.Trim())

                cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ReadItemsTable3() As DataTable
        Try
            Dim con As New Connection()
            If ConnectionState.Closed = con.connect.State Then
                con.connect.Open()
            End If

            Dim query As String = "SELECT * FROM studaddclass WHERE id = @id"
            Dim cmd As New MySqlCommand(query, con.connect)
            cmd.Parameters.AddWithValue("@id", MCourseForm.idnumlblb.Text)

            Using sda As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                sda.Fill(dt)
                Return dt
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function AddItemsToTable3(coursename As String, coursecode As String, coursegcode As String, time As String, tidnum As Integer, id As Integer,
                                     studfname As String, studlname As String) As Boolean
        Dim con As New Connection()
        If ConnectionState.Closed = con.connect.State Then
            con.connect.Open()
        End If

        Dim query As String = "INSERT INTO studaddclass(`coursename`, `coursecode`, `coursegcode`, `time`, `tlname`, `id`, `studfname`, `studlname`)VALUES(@coursename,@coursecode,@coursegcode,@time,@tidnum,@id,@studfname,@studlname)"
        Try
            Using cmd As New MySqlCommand(query, con.connect)
                cmd.Parameters.AddWithValue("coursename", coursename.ToString().Trim())
                cmd.Parameters.AddWithValue("coursecode", coursecode.ToString().Trim())
                cmd.Parameters.AddWithValue("coursegcode", coursegcode.ToString().Trim())
                cmd.Parameters.AddWithValue("time", time.Trim())
                cmd.Parameters.AddWithValue("tidnum", tidnum.ToString().Trim()) ' Assuming "ccode" is the correct parameter name
                cmd.Parameters.AddWithValue("id", id.ToString.Trim())
                cmd.Parameters.AddWithValue("studfname", studfname.Trim())
                cmd.Parameters.AddWithValue("studlname", studlname.Trim())

                cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function ReadItemsTable4() As DataTable
        Try
            Dim con As New Connection()
            If ConnectionState.Closed = con.connect.State Then
                con.connect.Open()
            End If

            Dim query As String = "SELECT * FROM tannouncement WHERE coursegcode = @coursegcode"
            Dim cmd As New MySqlCommand(query, con.connect)
            cmd.Parameters.AddWithValue("@coursegcode", StudCourseFeed.studcoursegcode.Text)

            Using sda As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                sda.Fill(dt)
                Return dt
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function AddItemsToTable4(idnum As Integer, firstname As String, lastname As String, datepost As String, coursename As String,
                                     coursegcode As String, content As String) As Boolean
        Dim con As New Connection()
        If ConnectionState.Closed = con.connect.State Then
            con.connect.Open()
        End If

        Dim query As String = "INSERT INTO tannouncement(`idnum`, `firstname`, `lastname`, `date`, `coursename`, `coursegcode`, `content`)VALUES(@idnum,@firstname,@lastname,@datepost,@coursename,@coursegcode,@content)"
        Try
            Using cmd As New MySqlCommand(query, con.connect)
                cmd.Parameters.AddWithValue("idnum", idnum.ToString().Trim())
                cmd.Parameters.AddWithValue("firstname", firstname.ToString().Trim())
                cmd.Parameters.AddWithValue("lastname", lastname.ToString().Trim())
                cmd.Parameters.AddWithValue("date", datepost.Trim())
                cmd.Parameters.AddWithValue("coursename", coursename.ToString().Trim()) ' Assuming "ccode" is the correct parameter name
                cmd.Parameters.AddWithValue("coursegcode", coursegcode.Trim())
                cmd.Parameters.AddWithValue("content", content.Trim())

                cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ReadItemsTable5() As DataTable
        Try
            Dim con As New Connection()
            If ConnectionState.Closed = con.connect.State Then
                con.connect.Open()
            End If

            Dim query As String = "SELECT * FROM teach_addcourse1 WHERE id = @id"
            Dim cmd As New MySqlCommand(query, con.connect)
            cmd.Parameters.AddWithValue("@id", TResource.Label1.Text)

            Using sda As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                sda.Fill(dt)
                Return dt
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function AddItemsToTable5(filename As String, coursename As String, coursecode As String, coursegcode As String, id As Integer,
                                     tfname As String, tlname As String) As Boolean
        Dim con As New Connection()
        If ConnectionState.Closed = con.connect.State Then
            con.connect.Open()
        End If

        Dim query As String = "INSERT INTO tuploadfile(`filename`, `coursename`, `coursecode`, `coursegcode`, `id`, `tfname`, `tlname`)VALUES(@filename,@coursename,@coursecode,@coursegcode,@id,@tfname,@tlname)"
        Try
            Using cmd As New MySqlCommand(query, con.connect)
                cmd.Parameters.AddWithValue("filename", filename.ToString().Trim())
                cmd.Parameters.AddWithValue("coursename", coursename.ToString().Trim())
                cmd.Parameters.AddWithValue("coursecode", coursecode.ToString().Trim())
                cmd.Parameters.AddWithValue("coursegcode", coursegcode.Trim())
                cmd.Parameters.AddWithValue("id", id.ToString().Trim()) ' Assuming "ccode" is the correct parameter name
                cmd.Parameters.AddWithValue("tfname", tfname.Trim())
                cmd.Parameters.AddWithValue("tlname", tlname.Trim())

                cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function ReadItemsTable6() As DataTable
        Try
            Dim con As New Connection()
            If ConnectionState.Closed = con.connect.State Then
                con.connect.Open()
            End If

            Dim query As String = "SELECT * FROM tuploadfile WHERE coursename = @coursename AND coursegcode = @cgcode"
            Dim cmd As New MySqlCommand(query, con.connect)
            cmd.Parameters.AddWithValue("@coursename", filecontent.Label1.Text)
            cmd.Parameters.AddWithValue("@cgcode", filecontent.Label2.Text)

            Using sda As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                sda.Fill(dt)
                Return dt
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function AddItemsToTable6(filename As String, coursename As String, coursecode As String, coursegcode As String, id As Integer,
                                     tfname As String, tlname As String) As Boolean
        Dim con As New Connection()
        If ConnectionState.Closed = con.connect.State Then
            con.connect.Open()
        End If

        Dim query As String = "INSERT INTO tuploadfile(`filename`, `coursename`, `coursecode`, `coursegcode`, `id`, `tfname`, `tlname`)VALUES(@filename,@coursename,@coursecode,@coursegcode,@id,@tfname,@tlname)"
        Try
            Using cmd As New MySqlCommand(query, con.connect)
                cmd.Parameters.AddWithValue("filename", filename.ToString().Trim())
                cmd.Parameters.AddWithValue("coursename", coursename.ToString().Trim())
                cmd.Parameters.AddWithValue("coursecode", coursecode.ToString().Trim())
                cmd.Parameters.AddWithValue("coursegcode", coursegcode.Trim())
                cmd.Parameters.AddWithValue("id", id.ToString().Trim()) ' Assuming "ccode" is the correct parameter name
                cmd.Parameters.AddWithValue("tfname", tfname.Trim())
                cmd.Parameters.AddWithValue("tlname", tlname.Trim())

                cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function ReadItemsTable7() As DataTable

        Try
            Dim con As New Connection()
            If ConnectionState.Closed = con.connect.State Then
                con.connect.Open()
            End If

            Dim query As String = "SELECT * FROM examss WHERE coursegcode = @coursegcode"
            Dim cmd As New MySqlCommand(query, con.connect)
            cmd.Parameters.AddWithValue("@coursegcode", StudCourseFeed.studcoursegcode.Text)

            Using sda As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                sda.Fill(dt)
                Return dt
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function AddItemsToTable7(assessno As Integer, coursename As String, coursecode As String, coursegcode As String, item1 As Integer,
                                     ques1 As String, choice1a As String, choice1b As String, choice1c As String, choice1d As String,
                                     ans1 As String, item2 As Integer, ques2 As String, choice2a As String, choice2b As String, choice2c As String, choice2d As String,
                                     ans2 As String, item3 As Integer, ques3 As String, choice3a As String, choice3b As String, choice3c As String, choice3d As String,
                                     ans3 As String, item4 As Integer, ques4 As String, choice4a As String, choice4b As String, choice4c As String, choice4d As String,
                                     ans4 As String, item5 As Integer, ques5 As String, choice5a As String, choice5b As String, choice5c As String, choice5d As String,
                                     ans5 As String, item6 As Integer, ques6 As String, choice6a As String, choice6b As String, choice6c As String, choice6d As String,
                                     ans6 As String, item7 As Integer, ques7 As String, choice7a As String, choice7b As String, choice7c As String, choice7d As String,
                                     ans7 As String, item8 As Integer, ques8 As String, choice8a As String, choice8b As String, choice8c As String, choice8d As String,
                                     ans8 As String, item9 As Integer, ques9 As String, choice9a As String, choice9b As String, choice9c As String, choice9d As String,
                                     ans9 As String, item10 As Integer, ques10 As String, choice10a As String, choice10b As String, choice10c As String, choice10d As String,
                                     ans10 As String) As Boolean
        Dim con As New Connection()
        If ConnectionState.Closed = con.connect.State Then
            con.connect.Open()
        End If

        Dim query As String = "INSERT INTO examss(assessno, coursename, coursecode, coursegcode, item1, ques1, choice1a, choice1b, choice1c, 
                                                            choice1d, ans1, item2, ques2, choice2a, choice2b, choice2c, choice2d, ans2, item3, ques3, 
                                                            choice3a, choice3b, choice3c, choice3d, ans3, item4, ques4, choice4a, choice4b, choice4c, 
                                                            choice4d, ans4, item5, ques5, choice5a, choice5b, choice5c, choice5d, ans5, item6, ques6, 
                                                            choice6a, choice6b, choice6c, choice6d, ans6, item7, ques7, choice7a, choice7b, choice7c, 
                                                            choice7d, ans7, item8, ques8, choice8a, choice8b, choice8c, choice8d, ans8, item9, ques9, 
                                                            choice9a, choice9b, choice9c, choice9d, ans9, item10, ques10, choice10a, choice10b, choice10c, 
                                                            choice10d, ans10) VALUES (@assessno, @coursename, @coursecode, @coursegcode, @item1, @ques1, 
                                                            @choice1a, @choice1b, @choice1c, @choice1d, @ans1, @item2, @ques2, @choice2a, @choice2b, @choice2c, 
                                                            @choice2d, @ans2, @item3, @ques3, @choice3a, @choice3b, @choice3c, @choice3d, @ans3, @item4, @ques4, 
                                                            @choice4a, @choice4b, @choice4c, @choice4d, @ans4, @item5, @ques5, @choice5a, @choice5b,
                                                            @choice5c, @choice5d, @ans5, @item6, @ques6, @choice6a, @choice6b, @choice6c, @choice6d, 
                                                            @ans6, @item7, @ques7, @choice7a, @choice7b, @choice7c, @choice7d, @ans7, @item8, @ques8, 
                                                            @choice8a, @choice8b, @choice8c, @choice8d, @ans8, @item9, @ques9, @choice9a, @choice9b, 
                                                            @choice9c, @choice9d, @ans9, @item10, @ques10, @choice10a, @choice10b, @choice10c, @choice10d, @ans10)"
        Try
            Using cmd As New MySqlCommand(query, con.connect)

                cmd.Parameters.AddWithValue("@assessno", assessno.ToString().Trim())
                cmd.Parameters.AddWithValue("@coursename", coursename.ToString().Trim())
                cmd.Parameters.AddWithValue("@coursecode", coursecode.ToString().Trim())
                cmd.Parameters.AddWithValue("@coursegcode", coursegcode.ToString().Trim())
                cmd.Parameters.AddWithValue("@item1", item1.ToString().Trim())
                cmd.Parameters.AddWithValue("@ques1", ques1.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice1a", choice1a.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice1b", choice1b.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice1c", choice1c.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice1d", choice1d.ToString().Trim())
                cmd.Parameters.AddWithValue("@ans1", ans1.ToString().Trim())
                cmd.Parameters.AddWithValue("@item2", item2.ToString().Trim())
                cmd.Parameters.AddWithValue("@ques2", ques2.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice2a", choice2a.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice2b", choice2b.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice2c", choice2c.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice2d", choice2d.ToString().Trim())
                cmd.Parameters.AddWithValue("@ans2", ans2.ToString().Trim())
                cmd.Parameters.AddWithValue("@item3", item3.ToString().Trim())
                cmd.Parameters.AddWithValue("@ques3", ques3.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice3a", choice3a.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice3b", choice3b.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice3c", choice3c.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice3d", choice3d.ToString().Trim())
                cmd.Parameters.AddWithValue("@ans3", ans3.ToString().Trim())
                cmd.Parameters.AddWithValue("@item4", item4.ToString().Trim())
                cmd.Parameters.AddWithValue("@ques4", ques4.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice4a", choice4a.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice4a", choice4a.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice4a", choice4a.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice4a", choice4a.ToString().Trim())
                cmd.Parameters.AddWithValue("@ans4", ans4.ToString().Trim())
                cmd.Parameters.AddWithValue("@item5", item5.ToString().Trim())
                cmd.Parameters.AddWithValue("@ques5", ques5.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice5a", choice5a.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice5b", choice5b.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice5c", choice5c.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice5d", choice5d.ToString().Trim())
                cmd.Parameters.AddWithValue("@ans5", ans5.ToString().Trim())
                cmd.Parameters.AddWithValue("@item6", item6.ToString().Trim())
                cmd.Parameters.AddWithValue("@ques6", ques6.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice6a", choice6a.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice6b", choice6b.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice6c", choice6c.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice6d", choice6d.ToString().Trim())
                cmd.Parameters.AddWithValue("@ans6", ans6.ToString().Trim())
                cmd.Parameters.AddWithValue("@item7", item7.ToString().Trim())
                cmd.Parameters.AddWithValue("@ques7", ques7.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice7a", choice7a.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice7b", choice7b.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice7c", choice7c.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice7d", choice7d.ToString().Trim())
                cmd.Parameters.AddWithValue("@ans7", ans7.ToString().Trim())
                cmd.Parameters.AddWithValue("@item8", item8.ToString().Trim())
                cmd.Parameters.AddWithValue("@ques8", ques8.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice8a", choice8a.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice8b", choice8b.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice8c", choice8c.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice8d", choice8d.ToString().Trim())
                cmd.Parameters.AddWithValue("@ans8", ans8.ToString().Trim())
                cmd.Parameters.AddWithValue("@item9", item9.ToString().Trim())
                cmd.Parameters.AddWithValue("@ques9", ques9.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice9a", choice9a.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice9b", choice9b.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice9c", choice9c.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice9d", choice9d.ToString().Trim())
                cmd.Parameters.AddWithValue("@ans9", ans9.ToString().Trim())
                cmd.Parameters.AddWithValue("@item10", item10.ToString().Trim())
                cmd.Parameters.AddWithValue("@ques10", ques10.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice10a", choice10a.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice10b", choice10b.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice10c", choice10c.ToString().Trim())
                cmd.Parameters.AddWithValue("@choice10d", choice10d.ToString().Trim())
                cmd.Parameters.AddWithValue("@ans10", ans10.ToString().Trim())


                cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ReadItemsTable8() As DataTable
        Try
            Dim con As New Connection()
            If ConnectionState.Closed = con.connect.State Then
                con.connect.Open()
            End If

            Dim query As String = "SELECT * FROM studaddclass WHERE id = @id"
            Dim cmd As New MySqlCommand(query, con.connect)
            cmd.Parameters.AddWithValue("@id", StudSign.idnum)

            Using sda As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                sda.Fill(dt)
                Return dt
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function AddItemsToTable8(filename As String, coursename As String, coursecode As String, coursegcode As String, id As Integer,
                                     tfname As String, tlname As String) As Boolean
        Dim con As New Connection()
        If ConnectionState.Closed = con.connect.State Then
            con.connect.Open()
        End If

        Dim query As String = "INSERT INTO tuploadfile(`filename`, `coursename`, `coursecode`, `coursegcode`, `id`, `tfname`, `tlname`)VALUES(@filename,@coursename,@coursecode,@coursegcode,@id,@tfname,@tlname)"
        Try
            Using cmd As New MySqlCommand(query, con.connect)
                cmd.Parameters.AddWithValue("filename", filename.ToString().Trim())
                cmd.Parameters.AddWithValue("coursename", coursename.ToString().Trim())
                cmd.Parameters.AddWithValue("coursecode", coursecode.ToString().Trim())
                cmd.Parameters.AddWithValue("coursegcode", coursegcode.Trim())
                cmd.Parameters.AddWithValue("id", id.ToString().Trim()) ' Assuming "ccode" is the correct parameter name
                cmd.Parameters.AddWithValue("tfname", tfname.Trim())
                cmd.Parameters.AddWithValue("tlname", tlname.Trim())

                cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ReadItemsTable9() As DataTable
        Try
            Dim con As New Connection()
            If ConnectionState.Closed = con.connect.State Then
                con.connect.Open()
            End If

            Dim query As String = "SELECT * FROM tuploadfile WHERE coursename = @coursename AND coursegcode=@coursegcode"
            Dim cmd As New MySqlCommand(query, con.connect)
            cmd.Parameters.AddWithValue("@coursename", StudFile.Label1.Text)
            cmd.Parameters.AddWithValue("@coursegcode", StudFile.Label2.Text)

            Using sda As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                sda.Fill(dt)
                Return dt
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function AddItemsToTable9(filename As String, coursename As String, coursecode As String, coursegcode As String, id As Integer,
                                     tfname As String, tlname As String) As Boolean
        Dim con As New Connection()
        If ConnectionState.Closed = con.connect.State Then
            con.connect.Open()
        End If

        Dim query As String = "INSERT INTO tuploadfile(`filename`, `coursename`, `coursecode`, `coursegcode`, `id`, `tfname`, `tlname`)VALUES(@filename,@coursename,@coursecode,@coursegcode,@id,@tfname,@tlname)"
        Try
            Using cmd As New MySqlCommand(query, con.connect)
                cmd.Parameters.AddWithValue("filename", filename.ToString().Trim())
                cmd.Parameters.AddWithValue("coursename", coursename.ToString().Trim())
                cmd.Parameters.AddWithValue("coursecode", coursecode.ToString().Trim())
                cmd.Parameters.AddWithValue("coursegcode", coursegcode.Trim())
                cmd.Parameters.AddWithValue("id", id.ToString().Trim()) ' Assuming "ccode" is the correct parameter name
                cmd.Parameters.AddWithValue("tfname", tfname.Trim())
                cmd.Parameters.AddWithValue("tlname", tlname.Trim())

                cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ReadItemsTable10() As DataTable
        Try
            Dim con As New Connection()
            If ConnectionState.Closed = con.connect.State Then
                con.connect.Open()
            End If

            Dim query As String = "SELECT * FROM teach_addcourse1 WHERE id = @id"
            Dim cmd As New MySqlCommand(query, con.connect)
            cmd.Parameters.AddWithValue("@id", TSignin.idnum)

            Using sda As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                sda.Fill(dt)
                Return dt
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ReadItemsTable11() As DataTable
        Try
            Dim con As New Connection()
            If ConnectionState.Closed = con.connect.State Then
                con.connect.Open()
            End If

            Dim query As String = "SELECT * FROM studaddclass WHERE id = @id"
            Dim cmd As New MySqlCommand(query, con.connect)
            cmd.Parameters.AddWithValue("@id", StudSign.idnum)

            Using sda As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                sda.Fill(dt)
                Return dt
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ReadItemsTable12() As DataTable
        Try
            Dim con As New Connection()
            If ConnectionState.Closed = con.connect.State Then
                con.connect.Open()
            End If

            Dim query As String = "SELECT * FROM notifyannounstudent WHERE coursegcode = @cgcode"
            Dim cmd As New MySqlCommand(query, con.connect)
            cmd.Parameters.AddWithValue("@cgcode", DboardForm.Label5.Text)

            Using sda As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                sda.Fill(dt)
                Return dt
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ReadItemsTable13() As DataTable
        Try
            Dim con As New Connection()
            If ConnectionState.Closed = con.connect.State Then
                con.connect.Open()
            End If

            Dim query As String = "SELECT * FROM notifyannounstudent WHERE coursegcode = @cgcode"
            Dim cmd As New MySqlCommand(query, con.connect)
            cmd.Parameters.AddWithValue("@cgcode", DboardForm.Label6.Text)

            Using sda As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                sda.Fill(dt)
                Return dt
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ReadItemsTable14() As DataTable
        Try
            Dim con As New Connection()
            If ConnectionState.Closed = con.connect.State Then
                con.connect.Open()
            End If

            Dim query As String = "SELECT * FROM notifyannounstudent WHERE coursegcode = @cgcode"
            Dim cmd As New MySqlCommand(query, con.connect)
            cmd.Parameters.AddWithValue("@cgcode", DboardForm.Label7.Text)

            Using sda As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                sda.Fill(dt)
                Return dt
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ReadItemsTable15() As DataTable
        Try
            Dim con As New Connection()
            If ConnectionState.Closed = con.connect.State Then
                con.connect.Open()
            End If

            Dim query As String = "SELECT * FROM notifyannounstudent WHERE coursegcode = @cgcode"
            Dim cmd As New MySqlCommand(query, con.connect)
            cmd.Parameters.AddWithValue("@cgcode", DboardForm.Label8.Text)

            Using sda As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                sda.Fill(dt)
                Return dt
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
