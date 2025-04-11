Imports Newtonsoft.Json.Serialization

Public Class ClassBLL

    Public Function SaveItems(id As Integer, lastname As String, coursename As String, ccode As Integer, coursetitle As String, cgcode As String, day As String,
                                    hours As String, time As String, term As String, room As String, program As String, image As Image) As Boolean
        Try
            Dim objdal As New ClassDAL()
            Return objdal.AddItemsToTable(id, lastname, coursename, ccode, coursetitle, cgcode, day, hours, time, term, room, program, image)
        Catch ex As Exception
            Dim result As DialogResult = MessageBox.Show(ex.Message.ToString())
            Return False
        End Try
    End Function

    Public Function GetItems() As DataTable
        Try
            Dim objdal As New ClassDAL()
            Return objdal.ReadItemsTable()
        Catch ex As Exception
            Dim result As DialogResult = MessageBox.Show(ex.Message.ToString())
            Return Nothing
        End Try
    End Function

    Public Function GetItems2() As DataTable
        Try
            Dim objdal As New ClassDAL()
            Return objdal.ReadItemsTable2()
        Catch ex As Exception
            Dim result As DialogResult = MessageBox.Show(ex.Message.ToString())
            Return Nothing
        End Try
    End Function

    Public Function SaveItems2(idnum As Integer, firstname As String, lastname As String, datepost As Integer, coursename As String,
                           coursegname As String, content As String) As Boolean
        Try
            Dim objdal As New ClassDAL()
            Return objdal.AddItemsToTable2(idnum, firstname, lastname, datepost, coursename, coursegname, content)
        Catch ex As Exception
            Dim result As DialogResult = MessageBox.Show(ex.Message.ToString())
            Return False
        End Try
    End Function

    Public Function GetItems3() As DataTable
        Try
            Dim objdal As New ClassDAL()
            Return objdal.ReadItemsTable3()
        Catch ex As Exception
            Dim result As DialogResult = MessageBox.Show(ex.Message.ToString())
            Return Nothing
        End Try
    End Function

    Public Function SaveItems3(coursename As String, coursecode As String, coursegcode As String, time As String, tidnum As Integer, id As Integer,
                                     studfname As String, studlname As String) As Boolean
        Try
            Dim objdal As New ClassDAL()
            Return objdal.AddItemsToTable3(coursename, coursecode, coursegcode, time, tidnum, id, studfname, studlname)
        Catch ex As Exception
            Dim result As DialogResult = MessageBox.Show(ex.Message.ToString())
            Return False
        End Try
    End Function

    Public Function GetItems4() As DataTable
        Try
            Dim objdal As New ClassDAL()
            Return objdal.ReadItemsTable4()
        Catch ex As Exception
            Dim result As DialogResult = MessageBox.Show(ex.Message.ToString())
            Return Nothing
        End Try
    End Function

    Public Function SaveItems4(idnum As Integer, firstname As String, lastname As String, datepost As Integer, coursename As String,
                           coursegname As String, content As String) As Boolean
        Try
            Dim objdal As New ClassDAL()
            Return objdal.AddItemsToTable4(idnum, firstname, lastname, datepost, coursename, coursegname, content)
        Catch ex As Exception
            Dim result As DialogResult = MessageBox.Show(ex.Message.ToString())
            Return False
        End Try
    End Function

    Public Function GetItems5() As DataTable
        Try
            Dim objdal As New ClassDAL()
            Return objdal.ReadItemsTable5()
        Catch ex As Exception
            Dim result As DialogResult = MessageBox.Show(ex.Message.ToString())
            Return Nothing
        End Try
    End Function

    Public Function SaveItems5(filename As String, coursename As String, coursecode As String, coursegcode As String, id As Integer,
                                     tfname As String, tlname As String) As Boolean
        Try
            Dim objdal As New ClassDAL()
            Return objdal.AddItemsToTable5(filename, coursename, coursecode, coursegcode, id, tfname, tlname)
        Catch ex As Exception
            Dim result As DialogResult = MessageBox.Show(ex.Message.ToString())
            Return False
        End Try
    End Function


    Public Function GetItems6() As DataTable
        Try
            Dim objdal As New ClassDAL()
            Return objdal.ReadItemsTable6()
        Catch ex As Exception
            Dim result As DialogResult = MessageBox.Show(ex.Message.ToString())
            Return Nothing
        End Try
    End Function

    Public Function SaveItems6(filename As String, coursename As String, coursecode As String, coursegcode As String, id As Integer,
                                     tfname As String, tlname As String) As Boolean
        Try
            Dim objdal As New ClassDAL()
            Return objdal.AddItemsToTable6(filename, coursename, coursecode, coursegcode, id, tfname, tlname)
        Catch ex As Exception
            Dim result As DialogResult = MessageBox.Show(ex.Message.ToString())
            Return False
        End Try
    End Function

    Public Function GetItems7() As DataTable
        Try
            Dim objdal As New ClassDAL()
            Return objdal.ReadItemsTable7()
        Catch ex As Exception
            Dim result As DialogResult = MessageBox.Show(ex.Message.ToString())
            Return Nothing
        End Try
    End Function

    Public Function SaveItems7(assessno As Integer, coursename As String, coursecode As String, coursegcode As String, item1 As Integer,
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
        Try
            Dim objdal As New ClassDAL()
            Return objdal.AddItemsToTable7(assessno, coursename, coursecode, coursegcode, item1, ques1, choice1a, choice1b, choice1c,
                                                            choice1d, ans1, item2, ques2, choice2a, choice2b, choice2c, choice2d, ans2, item3, ques3,
                                                            choice3a, choice3b, choice3c, choice3d, ans3, item4, ques4, choice4a, choice4b, choice4c,
                                                            choice4d, ans4, item5, ques5, choice5a, choice5b, choice5c, choice5d, ans5, item6, ques6,
                                                            choice6a, choice6b, choice6c, choice6d, ans6, item7, ques7, choice7a, choice7b, choice7c,
                                                            choice7d, ans7, item8, ques8, choice8a, choice8b, choice8c, choice8d, ans8, item9, ques9,
                                                            choice9a, choice9b, choice9c, choice9d, ans9, item10, ques10, choice10a, choice10b, choice10c,
                                                            choice10d, ans10)
        Catch ex As Exception
            Dim result As DialogResult = MessageBox.Show(ex.Message.ToString())
            Return False
        End Try
    End Function

    Public Function GetItems8() As DataTable
        Try
            Dim objdal As New ClassDAL()
            Return objdal.ReadItemsTable8()
        Catch ex As Exception
            Dim result As DialogResult = MessageBox.Show(ex.Message.ToString())
            Return Nothing
        End Try
    End Function

    Public Function SaveItems8(filename As String, coursename As String, coursecode As String, coursegcode As String, id As Integer,
                                     tfname As String, tlname As String) As Boolean
        Try
            Dim objdal As New ClassDAL()
            Return objdal.AddItemsToTable8(filename, coursename, coursecode, coursegcode, id, tfname, tlname)
        Catch ex As Exception
            Dim result As DialogResult = MessageBox.Show(ex.Message.ToString())
            Return False
        End Try
    End Function


    Public Function GetItems9() As DataTable
        Try
            Dim objdal As New ClassDAL()
            Return objdal.ReadItemsTable9()
        Catch ex As Exception
            Dim result As DialogResult = MessageBox.Show(ex.Message.ToString())
            Return Nothing
        End Try
    End Function

    Public Function SaveItems9(filename As String, coursename As String, coursecode As String, coursegcode As String, id As Integer,
                                     tfname As String, tlname As String) As Boolean
        Try
            Dim objdal As New ClassDAL()
            Return objdal.AddItemsToTable9(filename, coursename, coursecode, coursegcode, id, tfname, tlname)
        Catch ex As Exception
            Dim result As DialogResult = MessageBox.Show(ex.Message.ToString())
            Return False
        End Try
    End Function

    Public Function GetItems10() As DataTable
        Try
            Dim objdal As New ClassDAL()
            Return objdal.ReadItemsTable10()
        Catch ex As Exception
            Dim result As DialogResult = MessageBox.Show(ex.Message.ToString())
            Return Nothing
        End Try
    End Function

    Public Function GetItems11() As DataTable
        Try
            Dim objdal As New ClassDAL()
            Return objdal.ReadItemsTable11()
        Catch ex As Exception
            Dim result As DialogResult = MessageBox.Show(ex.Message.ToString())
            Return Nothing
        End Try
    End Function

    Public Function GetItems12() As DataTable
        Try
            Dim objdal As New ClassDAL()
            Return objdal.ReadItemsTable12()
        Catch ex As Exception
            Dim result As DialogResult = MessageBox.Show(ex.Message.ToString())
            Return Nothing
        End Try
    End Function

    Public Function GetItems13() As DataTable
        Try
            Dim objdal As New ClassDAL()
            Return objdal.ReadItemsTable13()
        Catch ex As Exception
            Dim result As DialogResult = MessageBox.Show(ex.Message.ToString())
            Return Nothing
        End Try
    End Function

    Public Function GetItems14() As DataTable
        Try
            Dim objdal As New ClassDAL()
            Return objdal.ReadItemsTable14()
        Catch ex As Exception
            Dim result As DialogResult = MessageBox.Show(ex.Message.ToString())
            Return Nothing
        End Try
    End Function

    Public Function GetItems15() As DataTable
        Try
            Dim objdal As New ClassDAL()
            Return objdal.ReadItemsTable15()
        Catch ex As Exception
            Dim result As DialogResult = MessageBox.Show(ex.Message.ToString())
            Return Nothing
        End Try
    End Function

End Class
