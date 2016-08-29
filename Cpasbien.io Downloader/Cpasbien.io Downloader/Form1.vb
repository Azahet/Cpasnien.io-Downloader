Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Threading


' dp""b8   dp"yb  8888b.   888888    88""yb     db     88""yb    
'dp   `"  dp   yb  8i  yb  88__      88__dp    dpyb    88__dp    
'yb       yb   dp  8I  dy  88""      88"""    dp__yb   88"yb      
' yboodp   ybodp  8888y"   888888    88      dp""""yb  88  yb      
'
' dp"yb  8b    d8  88b 88  88  .dp"y8   dp""b8  88  888888  88b 88  888888
'dp   yb 88b  d88  88yb88      `ybo.   dp   `"      88__    88yb88    88
'yb   dp 88ybdp88  88 y88  88    `y8b  yb       88  88""    88 y88    88 
' ybodp  88 yy 88  88  y8  88  8bodp'   yboodp  88  888888  88  y8    88  

'thank's to JOniiX for the idea and the snipet "Bande annonce"


Public Class Form1

    Dim page_recherche As String = 0
    Dim page_download As String
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        FlatListBox1.rmvItem()
        page_recherche = 0
        recherche(FlatTextBox1.Text)
    End Sub

    Private Sub recherche(url_recherche As String)
        url_recherche = FlatTextBox1.Text.Replace(" ", "-")
        Dim request As WebRequest = WebRequest.Create("http://www.cpasbien.cm/recherche/" + url_recherche + "/page-" + page_recherche)
        Using response As WebResponse = request.GetResponse()
            Using reader As New StreamReader(response.GetResponseStream())
                Dim html As String = reader.ReadToEnd()
                If html.Contains("<strong>Pas</strong>") Then
                    page_recherche += +1
                    MessageBox.Show("Impossible d'atteindre la page " + page_recherche)
                    page_recherche += -1
                Else
                    Dim matches As MatchCollection = Regex.Matches(html, "class=""titre"">(.*?)</a>")
                    For Each m As Match In matches
                        FlatListBox1.AddItem(m.Groups(1).Captures(0).Value)
                    Next
                End If
            End Using
        End Using
    End Sub

    Private Sub down_all(nom As String)
        Dim nb_base = String.Empty
        Dim nb_down = String.Empty
        Dim matches As MatchCollection = Regex.Matches(nom, "s(.*?)e(.*?)-")
        For Each m As Match In matches
            nb_base = m.Groups(2).Captures(0).Value
            nb_down = m.Groups(2).Captures(0).Value
        Next
        For index = 1 To Integer.Parse(nb_base)
            If nb_base = nb_down Then
                My.Computer.Network.DownloadFile(
                    "http://www.cpasbien.cm/telechargement/" + nom.Replace(nb_base, nb_down) & ".torrent",
                    "[CPASBIEN]" & nom.Replace(nb_base, nb_down) & ".torrent")
            Else
                Try
                    If nb_down > 9 Then
                        My.Computer.Network.DownloadFile(
                    "http://www.cpasbien.cm/telechargement/" + nom.Replace(nb_base, nb_down).Replace("-final", "") & ".torrent",
                    "[CPASBIEN]" & nom.Replace(nb_base, nb_down).Replace("-final", "") & ".torrent")
                    Else
                        My.Computer.Network.DownloadFile(
                   "http://www.cpasbien.cm/telechargement/" & nom.Replace(nb_base, "0" & nb_down).Replace("-final", "") & ".torrent",
                   "[CPASBIEN]" & nom.Replace(nb_base, nb_down).Replace("-final", "") & ".torrent")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Imposible de télécharger l'épisode : " & nb_down)
                End Try
            End If
            nb_down += -1
        Next
    End Sub



    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        FlatListBox1.rmvItem()
        page_recherche += -1
        recherche(FlatTextBox1.Text)
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        FlatListBox1.rmvItem()
        page_recherche += +1
        recherche(FlatTextBox1.Text)
    End Sub

    Private Sub TéléchargerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TéléchargerToolStripMenuItem.Click
        page_download = FlatListBox1.SelectedItem.ToString.Replace(" ", "-").ToLower
        My.Computer.Network.DownloadFile(
           "http://www.cpasbien.cm/telechargement/" + page_download + ".torrent",
            page_download + ".torrent")
    End Sub

    Private Sub TélécharerLaSaisonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TélécharerLaSaisonToolStripMenuItem.Click
        down_all(FlatListBox1.SelectedItem.ToString.Replace(" ", "-").ToLower)
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        bande_annonce()
    End Sub

    Private Sub bande_annonce()
        Dim film As String = FlatListBox1.SelectedItem
        Dim words() As String = {"DVDRIP", "DVDSCR", "FRENCH", "VOSTFR", "WEBRIP", "HDTV", "FINAL"}

        For Each elem As String In words
            film = film.Replace(" " + elem, "").Replace(" ", "+")
        Next
        Process.Start("https://www.youtube.com/results?search_query=" + film + " bande annonce")
End Sub
End Class
